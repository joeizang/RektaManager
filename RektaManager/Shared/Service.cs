using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManager.Shared.Abstractions;

namespace RektaManager.Shared
{
    public class Service : DomainModelBase
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public Booking ServiceBooking { get; set; }

        public Guid ServiceBookingId { get; set; }
        
    }
}
