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
    public class Product : DomainModelBase
    {
        public string Name { get; set; }

        [Column(TypeName = "decimal(20,2)")]
        public decimal CostPrice { get; set; }

        public double QuantityBought { get; set; }

        public string ProductUniqueIdentifier { get; set; }

        public virtual List<ProductCategory> ProductCategories { get; set; }

        public UnitMeasure UnitMeasure { get; set; }

        public Inventory ProductInventory { get; set; }

        public int ProductInventoryId { get; set; }

        public string Description { get; set; }

    }
}
