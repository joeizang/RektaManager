using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManagerApp.Shared.Abstractions;

namespace RektaManagerApp.Shared
{
    public class BookingSales : DomainModelBase
    {
        public Booking Booking { get; set; }

        public int BookingId { get; set; }

        public Invoice Invoice { get; set; }

        public int InvoiceId { get; set; }

    }
}
