using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManager.Shared.Abstractions;

namespace RektaManager.Shared
{
    public class Product : DomainModelBase
    {
        public string Name { get; set; }

        public decimal CostPrice { get; set; }

        public double QuantityBought { get; set; }

        public string ProductUniqueIdentifier { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }

        public UnitMeasure UnitMeasure { get; set; }

        public string Description { get; set; }

    }
}
