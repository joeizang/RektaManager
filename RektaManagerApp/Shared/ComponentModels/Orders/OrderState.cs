using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManagerApp.Shared.ComponentModels.Orders
{
    public class OrderState
    {
        public OrderState()
        {

        }
        public List<OrderedItemUpsertComponentModel> OrderedItems { get; set; } = new();

        public List<OrderItemComponentModel> OrderItems { get; set; } = new();
    }
}
