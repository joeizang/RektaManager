using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using RektaManagerApp.Shared.ComponentModels.Orders;

namespace RektaManagerApp.Client.Utils
{
    public class OrderService : IOrderService
    {
        private readonly ILocalStorageService _localStorage;
        public event Action OnChange;

        public OrderService(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }
        public async Task AddToCart(List<OrderedItemUpsertComponentModel> item)
        {
            var currentCart = await _localStorage.GetItemAsync<List<OrderedItemUpsertComponentModel>>("currentCart") ??
                              new List<OrderedItemUpsertComponentModel>();
            await _localStorage.SetItemAsync("currentCart", item);
            OnChange?.Invoke();
        }
    }
}
