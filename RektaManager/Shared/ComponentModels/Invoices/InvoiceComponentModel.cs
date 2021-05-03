using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManager.Shared.ComponentModels.Invoices
{
    public class InvoiceComponentModel
    {
        public int InvoiceId { get; set; }

        public string CustomerName { get; set; }

        public DateTimeOffset TransactionDate { get; set; }

        public DateTimeOffset? DueDate { get; set; }

        public bool InvoicePaymentStatus { get; set; }

        public int CustomerId { get; set; }

        public int InvoicePaymentId { get; set; }

        public int? OrderId { get; set; }

        public int? BookingId { get; set; }


    }

    public class InvoiceListComponentModel
    {
        public DateTimeOffset TransactionDate { get; set; }

        public int NumberOfOrders { get; set; }

        public string CustomerName { get; set; }

        public bool InvoicePaymentStatus { get; set; }

        public DateTimeOffset? DueDate { get; set; }

    }
}
