using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RektaManager.Server.Queries.Inventories
{
    public class GetInventoriesQuery
    {
        public string InventoryName { get; set; } = string.Empty;

        public DateTimeOffset Date { get; set; }

        public int DateOffset { get; set; }

        public decimal Price { get; set; }
    }
}
