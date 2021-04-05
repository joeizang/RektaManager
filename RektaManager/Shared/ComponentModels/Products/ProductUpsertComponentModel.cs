using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManager.Shared.Abstractions;

namespace RektaManager.Shared.ComponentModels.Products
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

        public string Name { get; set; }

        public decimal CostPrice { get; set; }

        public double QuantityBought { get; set; }

        public string ProductUniqueIdentifier { get; set; }

        public UnitMeasure UnitMeasure { get; set; }

        public int ProductInventoryId { get; set; }

        public int SupplierId { get; set; }

        public string Description { get; set; }

    }
}
