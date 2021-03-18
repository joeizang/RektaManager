using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManager.Shared.ComponentModels.Inventories
{
    public class InventoryUpsertComponentModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required] public DateTimeOffset SupplyDate { get; set; } = DateTimeOffset.UtcNow;

        [Required]
        public double Quantity { get; set; }

        public int Id { get; set; }
    }
}
