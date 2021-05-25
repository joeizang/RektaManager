using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RektaManager.Shared.ComponentModels.Orders;

namespace RektaManager.Client.Utils
{
    public interface IOrderService
    {
        event Action OnChange;

        Task AddToCart(List<OrderedItemUpsertComponentModel> items);
    }
}
