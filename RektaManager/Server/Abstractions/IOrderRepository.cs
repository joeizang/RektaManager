using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using RektaManager.Shared.Abstractions;
using RektaManager.Shared.ComponentModels.Orders;

namespace RektaManager.Server.Abstractions
{
    public interface IOrderRepository : IRepository
    {
        Task<OrderComponentModel> GetOrderBy(string searchTerm);

        Task<OrderedItemComponentModel> GetOrderedItemBy(string searchTerm);

        Task<OrderItemComponentModel> GetOrderItemBy(string searchTerm);

        Task Update(OrderUpsertComponentModel entity);
    }
}
