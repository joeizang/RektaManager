using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManager.Shared.Abstractions;

namespace RektaManager.Shared
{
    public class BookedItem : DomainModelBase
    {
        [Column(TypeName = "decimal(20,2)")]
        public decimal Price { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }

        public double Quantity { get; set; }
        
        [StringLength(50)]
        public string Name { get; set; }

        public int BookingId { get; set; }

        public Booking RequiredBooking { get; set; }
    }
}
