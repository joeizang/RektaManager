using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManagerApp.Shared.Abstractions;

namespace RektaManagerApp.Shared.ComponentModels.Orders
{
    public class OrderUpsertComponentModel : BaseUpsertComponentModel
    {
        [Required]
        [StringLength(100)]
        public string CustomerName { get; set; }

        [StringLength(50)]
        public string CustomerPhoneNumber { get; set; }

        [Required]
        public DateTimeOffset OrderDate { get; set; }

        [Required]
        public string StaffId { get; set; }
        
        [Required]
        public List<OrderedItemUpsertComponentModel> OrderedItems { get; set; }

        public decimal OrderTotal { get; set; }

    }
}
