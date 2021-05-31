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
    public class Booking : DomainModelBase
    {
        [Column(TypeName = "decimal(20,2)")]
        public decimal Deposit { get; set; }

        [Column(TypeName = "decimal(20,2)")]
        public decimal Total { get; set; }

        public DateTimeOffset BookingDate { get; set; }

        public DateTimeOffset EventDate { get; set; } // code in validations to make sure that booking don't happen too close to event date or too far.

        public ApplicationUser StaffProcessing { get; set; }

        public string StaffId { get; set; }

        public Customer Customer { get; set; }

        public int CustomerId { get; set; }

        public  List<BookingSales> BookingSalesInvoices { get; set; }

        public int InvoiceId { get; set; }

        public Invoice Invoice { get; set; }

        public  List<BookedItem> BookedItems { get; set; }

        public  List<Service> BookedServices { get; set; }

    }
}
