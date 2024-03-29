﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using RektaManagerApp.Shared.Abstractions;

namespace RektaManagerApp.Server.Abstractions
{
    public interface IRepository
    {
        Task<int> Save<T>() where T : DomainModelBase;

        Task<IEnumerable<T>> GetByPredicate<T>(Expression<Func<T, bool>> predicate) where T : DomainModelBase;

        public IQueryable<T> GetQueryable<T>(Expression<Func<T, bool>>[] predicates = null,
            RequestCustomizer query = null, params Expression<Func<T, object>>[] includes) where T : DomainModelBase;

        Task<T> GetOne<T>(int id) where T : DomainModelBase;

        Task Add<T>(T entity) where T : DomainModelBase;

        Task Update<T>(T entity, T target, BaseActionsAudit audit) where T : DomainModelBase;

        Task Delete<T>(int id) where T : DomainModelBase;

        string GenerateStringId();
    }
}
