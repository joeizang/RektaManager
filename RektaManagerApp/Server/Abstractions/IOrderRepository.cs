using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using RektaManagerApp.Shared.Abstractions;
using RektaManagerApp.Shared.ComponentModels.Orders;

namespace RektaManagerApp.Server.Abstractions
{
    public interface IOrderRepository : IRepository
    {
        Task<OrderComponentModel> GetOrderBy(string searchTerm);

        Task<OrderedItemComponentModel> GetOrderedItemBy(string searchTerm);

        Task<OrderItemComponentModel> GetOrderItemBy(string searchTerm);

        Task Update(OrderUpsertComponentModel entity);
    }
}
