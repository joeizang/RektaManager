using RektaManagerApp.Shared.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManagerApp.Shared.ComponentModels.Bookings
{
    public class BookedItemUpsertComponentModel : BaseUpsertComponentModel
    {
        [Required]
        public decimal Price { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

    }
}
