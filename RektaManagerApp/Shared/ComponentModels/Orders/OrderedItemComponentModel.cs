using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManagerApp.Shared.ComponentModels.Orders
{
    public class OrderedItemComponentModel
    {
        [Required]
        [StringLength(100)]
        public string ItemName { get; set; }

        [Required]
        public decimal ItemPrice { get; set; }

        [Required]
        [StringLength(10)]
        public string ItemCode { get; set; }

        [Required]
        public double Quantity { get; set; }
    }
}
