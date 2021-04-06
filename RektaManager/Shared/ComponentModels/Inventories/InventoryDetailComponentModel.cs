using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManager.Shared.ComponentModels.Products;

namespace RektaManager.Shared.ComponentModels.Inventories
{
    public class InventoryDetailComponentModel
    {
        public List<string> InventoryCategories { get; set; }
        public List<ProductComponentModel> Products { get; set; }

        public string Name { get; set; }

        public DateTimeOffset Date { get; set; }

        public int InventoryId { get; set; }
    }
}
