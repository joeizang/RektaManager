using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using RektaManager.Shared.Abstractions;

namespace RektaManager.Server.Abstractions
{
    public interface IRepository
    {
        Task Save<T>() where T : DomainModelBase;

        Task<IEnumerable<T>> GetByPredicate<T>(Expression<Func<T, bool>> predicate) where T : DomainModelBase;

        Task<T> GetOne<T>(int id) where T : DomainModelBase;

        Task Add<T>(T entity) where T : DomainModelBase;

        Task Update<T>(T entity) where T : DomainModelBase;

        Task Delete<T>(int id) where T : DomainModelBase;
    }
}
