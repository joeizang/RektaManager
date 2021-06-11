using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using RektaManagerApp.Server.Abstractions;
using RektaManagerApp.Server.Data;
using RektaManagerApp.Shared;
using RektaManagerApp.Shared.Abstractions;

namespace RektaManagerApp.Server.Services
{
    public class BaseRepository : IRepository
    {
        private readonly RektaManagerAppContext _context;
        private readonly IHttpContextAccessor _httpContext;

        public BaseRepository(RektaManagerAppContext context, IHttpContextAccessor httpContext)
        {
            _context = context;
            _httpContext = httpContext;
        }
        public async Task<int> Save<T>() where T : DomainModelBase
        {
            var user = _httpContext.HttpContext.User.Identity.Name ?? "Unknown";
            foreach (var entity in _context.ChangeTracker.Entries<T>())
            {
                if (entity.State == EntityState.Added)
                {
                    entity.Entity.CreatedAt = DateTimeOffset.UtcNow.LocalDateTime;
                    entity.Entity.UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime;
                    if (string.IsNullOrEmpty(entity.Entity.CreatedBy))
                    {
                        entity.Entity.CreatedBy = user;
                        entity.Entity.UpdatedBy = user;
                    }
                }

                if (entity.State == EntityState.Modified)
                {
                    entity.Entity.UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime;
                    entity.Entity.UpdatedBy = user;
                }
            }

            return await _context.SaveChangesAsync();
        }
        
        public async Task<IEnumerable<T>> GetByPredicate<T>(Expression<Func<T, bool>> predicate) where T : DomainModelBase
        {
            var result = await _context.Set<T>().AsNoTracking().Where(predicate).ToListAsync();
            return result;
        }

        public async Task<T> GetOne<T>(int id) where T : DomainModelBase
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task Add<T>(T entity) where T : DomainModelBase
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public async Task Update<T>(T entity, T target, BaseActionsAudit audit) where T : DomainModelBase
        {
            var modified = _context.ChangeTracker.Entries<T>()
                .Where(x => x.State == EntityState.Modified)
                .SingleOrDefault();

            var dbVal = await modified.GetDatabaseValuesAsync();
            var fromDb = dbVal.ToObject() as T;

            var changes = new PropertyChanges<T>(modified, fromDb);

            audit.Actions = ActionPerformed.Updated;
            audit.Changes = JsonSerializer.Serialize(changes);

            //var compareTimestampResult = Xor(entity.Timestamp, target.Timestamp);

            _context.Entry(target).State = EntityState.Modified;
            
            try
            {

                //if (compareTimestampResult)
                //{
                //    _context.Entry(target).State = EntityState.Modified;
                //}
                //else
                //{
                //    entity.Timestamp = target.Timestamp; //once serious concurrency is attained, update this strategy

                //    _context.Set<T>().Update(entity);
                //}

                entity.Timestamp = target.Timestamp;
                _context.Set<T>().Update(target);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public IQueryable<T> GetQueryable<T>(Expression<Func<T, bool>>[] predicates = null,
            RequestCustomizer query = null, params Expression<Func<T, object>>[] includes) where T : DomainModelBase
        {
            var queryable = _context.Set<T>().AsNoTracking();
            if (query is null && predicates is null)
            {
                foreach (var include in includes)
                {
                    queryable = queryable.Include(include);
                }

                return queryable;
            }

            var index = 0;
            if (predicates is not null && query is not null)
            {
                if (includes.Length > 0)
                {
                    while (index <= predicates.Length)
                    {
                        queryable = queryable.Where(predicates[index]);
                        index++;
                    }
                }
            }

            return queryable;
        }

        public async Task Delete<T>(int id) where T : DomainModelBase
        {
            var result = await _context.Set<T>().FindAsync(id);
            result.IsDeleted = true;
            _context.Set<T>().Update(result);

        }

        private static bool Xor(byte[] a, byte[] b)
        {

            int x = a.Length ^ b.Length;

            for (int i = 0; i < a.Length && i < b.Length; ++i)
            {

                x |= a[i] ^ b[i];

            }

            return x == 0;

        }

        public string GenerateStringId()
        {
            var temp = Guid.NewGuid().ToString();
            var stamp = DateTimeOffset.UtcNow.LocalDateTime.TimeOfDay.ToString();

            return $"{temp}-{stamp}";
        }
    }
}
