using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManagerApp.Shared.Abstractions;

namespace RektaManagerApp.Shared.ComponentModels.Products
{
    public class ProductUpsertComponentModel : BaseUpsertComponentModel
    {
        public ProductUpsertComponentModel()
        {
            if (string.IsNullOrEmpty(ProductUniqueIdentifier))
            {
                ProductUniqueIdentifier =
                    $"{Guid.NewGuid():N}-{DateTimeOffset.UtcNow.Ticks}";
            }
        }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public decimal CostPrice { get; set; }

        [Required]
        public double QuantityBought { get; set; }

        public string ProductUniqueIdentifier { get; set; }

        [Required]
        public UnitMeasure UnitMeasure { get; set; }

        [Required]
        public int ProductInventoryId { get; set; }

        [Required]
        public int SupplierId { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

    }
}
