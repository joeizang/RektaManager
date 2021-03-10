using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RektaManager.Server.Commands.Inventories
{
    public class PutInventoryCommand
    {
        [StringLength(150)]
        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Required]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTimeOffset SupplyDate { get; set; }

        [Required]
        public double Quantity { get; set; }

        public int Id { get; set; }

    }
}
