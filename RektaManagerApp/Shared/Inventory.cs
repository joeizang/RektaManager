using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManagerApp.Shared.Abstractions;

namespace RektaManagerApp.Shared
{
    public class Inventory : DomainModelBase
    {
        public  List<Product> Products { get; set; }

        public  List<InventoryCategory> InventoryCategories { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public DateTimeOffset SupplyDate { get; set; }

        [Column(TypeName = "decimal(20,2)")]
        public decimal TotalInventoryValuation { get; set; }
    }
}
