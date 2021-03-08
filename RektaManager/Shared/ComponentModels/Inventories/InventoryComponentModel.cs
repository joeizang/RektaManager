using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManager.Shared.ComponentModels.Inventories
{
    public class InventoryComponentModel
    {
        [Display(Name = "Inventory Name")]
        public string InventoryName { get; set; }

        [Display(Name = "Inventory Date")]
        [DisplayFormat(DataFormatString = "dd MMM yyyy")]
        public DateTimeOffset InventoryDate { get; set; }

        [Display(Name = "Quantity available")]
        public double QuantityInStock { get; set; }

        public int InventoryId { get; set; }

        public string CategoryName { get; set; }
    }
}
