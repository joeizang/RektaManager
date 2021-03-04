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
        public decimal Deposit { get; set; }

        public decimal Total { get; set; }
        
        public DateTimeOffset BookingDate { get; set; }

        public DateTimeOffset EventDate { get; set; } // code in validations to make sure that booking don't happen too close to event date or too far.

        public ApplicationUser StaffProcessing { get; set; }

        public string StaffId { get; set; }

        public List<BookingSales> BookingSalesInvoices { get; set; }

        public Guid InvoiceId { get; set; }

        public List<BookedItem> BookedItems { get; set; }

        public List<Service> BookedServices { get; set; }

    }
}
