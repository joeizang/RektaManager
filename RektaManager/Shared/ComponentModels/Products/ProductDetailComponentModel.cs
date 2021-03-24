using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManager.Shared.ComponentModels.Products
{
    public class ProductDetailComponentModel
    {
        public string Name { get; set; }

        public decimal CostPrice { get; set; }

        public double QuantityBought { get; set; }

        public string ProductUniqueIdentifier { get; set; }

        public UnitMeasure UnitMeasure { get; set; }

        public string Description { get; set; }

        public int ProductId { get; set; }
        
        public string InventoryName { get; set; }

        public byte[] Timestamp { get; set; }

    }
}
