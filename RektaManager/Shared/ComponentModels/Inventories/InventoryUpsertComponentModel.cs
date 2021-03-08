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
        [StringLength(150)]
        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Required]
        [DisplayFormat(DataFormatString = "c")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        [Required]
        [DisplayFormat(DataFormatString = "dd MMM yyyy")]
        public DateTimeOffset SupplyDate { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "d")]
        public double Quantity { get; set; }
    }
}
