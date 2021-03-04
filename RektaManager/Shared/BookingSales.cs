using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManager.Shared.Abstractions;

namespace RektaManager.Shared
{
    public class BookingSales : DomainModelBase
    {
        public Booking Booking { get; set; }

        public Guid BookingId { get; set; }

        public Invoice Invoice { get; set; }

        public Guid InvoiceId { get; set; }

    }
}
