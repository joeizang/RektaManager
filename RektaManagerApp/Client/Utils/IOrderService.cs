using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RektaManagerApp.Shared.ComponentModels.Orders;

namespace RektaManagerApp.Client.Utils
{
    public interface IOrderService
    {
        event Action OnChange;

        Task AddToCart(List<OrderedItemUpsertComponentModel> items);
    }
}
