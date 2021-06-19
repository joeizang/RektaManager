using MediatR;
using RektaManagerApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RektaManagerApp.Server.Notifications.Invoices
{
    public class InvoiceCreatedNotification : INotification
    {
        public string InvoiceId { get; set; }

        public DateTimeOffset TransactionDate { get; set; }

        public DateTimeOffset DueDate { get; set; }

        public string Description { get; set; }

        public decimal Total { get; set; }

        public bool FullyPaid { get; set; }


        public int CustomerId { get; set; }

        public string CreatedBy { get; set; }

        public List<BookedItem> BookedItems { get; set; }

        public List<Service> Services { get; set; }

    }
}
