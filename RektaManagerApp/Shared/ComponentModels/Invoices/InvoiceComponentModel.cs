using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManagerApp.Shared.ComponentModels.Invoices
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

        public int InvoiceId { get; set; }

    }


    public class InvoiceUpsertComponentModel
    {
        public DateTime TransactionDate { get; set; }

        public DateTime DueDate { get; set; }

        public string Description { get; set; }

        public bool InvoicePaymentStatus { get; set; }

        public string CustomerName { get; set; }

        public string CustomerPhone { get; set; }

        public decimal Amount { get; set; }

        public decimal Total { get; set; }

        public bool IsPartPayment { get; set; }
    }
}
