using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManager.Shared.Abstractions;

namespace RektaManager.Shared
{
    public class Booking : DomainModelBase
    {
        public DateTimeOffset BookingDate { get; set; }

        public DateTimeOffset EventDate { get; set; } // code in validations to make sure that booking don't happen too close to event date or too far.

        public List<BookedItem> BookedItems { get; set; }

        public List<Service> BookedServices { get; set; }

    }
}
