using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManager.Shared.ComponentModels.Orders
{
    public class OrderComponentModel
    {
        public string CustomerName { get; set; }

        public string CustomerPhone { get; set; }

        public DateTimeOffset OrderDate { get; set; }

        public decimal OrderTotal { get; set; }

        public IEnumerable<OrderedItemComponentModel> OrderedItems { get; set; }

        public string StaffName { get; set; }

        public int OrderId { get; set; }

    }
}
