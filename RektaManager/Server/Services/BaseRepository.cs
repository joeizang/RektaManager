using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using RektaManager.Server.Abstractions;
using RektaManager.Server.Data;
using RektaManager.Shared.Abstractions;

namespace RektaManager.Server.Services
{
    public class BaseRepository : IRepository
    {
        private readonly RektaManagerContext _context;
        private readonly IHttpContextAccessor _httpContext;

        public BaseRepository(RektaManagerContext context, IHttpContextAccessor httpContext)
        {
            _context = context;
            _httpContext = httpContext;
        }
        public async Task Save<T>() where T : DomainModelBase
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

            await _context.SaveChangesAsync();
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

        public async Task Update<T>(T entity) where T : DomainModelBase
        {
            try
            {
                var target = await _context.Set<T>().FindAsync(entity.Id);

                if (Convert.ToBase64String(entity.Timestamp) == Convert.ToBase64String(target.Timestamp))
                {
                    _context.Entry(target).State = EntityState.Modified;
                }
                else
                {
                    entity.Timestamp = target.Timestamp; //once serious concurrency is attained, update this strategy

                    _context.Set<T>().Update(entity);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task Delete<T>(int id) where T : DomainModelBase
        {
            var result = await _context.Set<T>().FindAsync(id);
            result.IsDeleted = true;
            _context.Set<T>().Update(result);

        }
    }
}
