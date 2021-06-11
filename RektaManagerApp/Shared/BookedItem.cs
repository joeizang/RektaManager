using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManagerApp.Shared.Abstractions;

namespace RektaManagerApp.Shared
{
    public class BookedItem : DomainModelBase
    {
        [Column(TypeName = "decimal(20,2)")]
        public decimal Price { get; set; }

        public double Quantity { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public string BookingId { get; set; }

        public Booking RequiredBooking { get; set; }
    }
}
