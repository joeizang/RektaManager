using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RektaManager.Server.Commands.Inventories
{
    public class PutInventoryCommand
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Quantity { get; set; }

        public decimal Price { get; set; }

        public DateTimeOffset SupplyDate { get; set; }

    }
}
