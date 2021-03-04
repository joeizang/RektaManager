using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManager.Shared.Abstractions;

namespace RektaManager.Shared
{
    public class BookedItem : DomainModelBase
    {
        public decimal Price { get; set; }

        public double Quantity { get; set; }
        
        [StringLength(50)]
        public string Name { get; set; }

        public Guid BookingId { get; set; }

        public Booking RequiredBooking { get; set; }
    }
}
