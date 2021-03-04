using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManager.Shared.Abstractions;

namespace RektaManager.Shared
{
    public class Inventory : DomainModelBase
    {
        public List<Product> Products { get; set; }

        public List<InventoryCategory> InventoryCategories { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public double Quantity { get; set; }

        [Required]
        public DateTimeOffset SupplyDate { get; set; }
        
        [Required]
        public decimal Price { get; set; }

        [NotMapped]
        public decimal TotalInventoryValuation { get; set; }
    }
}
