using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManagerApp.Shared.ComponentModels.Inventories
{
    public class InventoryUpsertComponentModel
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required] 
        public DateTime SupplyDate { get; set; } = DateTime.UtcNow;

        [Required]
        public double Quantity { get; set; }

        public int Id { get; set; }
    }
}
