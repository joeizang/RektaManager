using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManager.Shared.Abstractions;

namespace RektaManager.Shared.ComponentModels.Orders
{
    public class OrderedItemUpsertComponentModel : BaseUpsertComponentModel
    {

        public string ItemName { get; set; }

        public decimal ItemPrice { get; set; }

        public string ItemCode { get; set; }

        public double Quantity { get; set; }

        public string SalesStaff { get; set; }

        public DateTimeOffset OrderDate { get; set; }

        public string CustomerName { get; set; }

    }
}
