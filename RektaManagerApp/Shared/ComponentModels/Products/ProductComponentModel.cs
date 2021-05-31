using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManagerApp.Shared.ComponentModels.Products
{
    public class ProductComponentModel
    {
        public string Name { get; set; }

        public decimal CostPrice { get; set; }

        public double QuantityBought { get; set; }

        public string ProductUniqueIdentifier { get; set; }

        public UnitMeasure UnitMeasure { get; set; }


        public int ProductInventoryId { get; set; }

        public string Description { get; set; }

        public int ProductId { get; set; }

        public string InventoryName { get; set; }
    }
}
