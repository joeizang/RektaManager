using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManager.Shared.Abstractions;

namespace RektaManager.Shared
{
    public class Invoice : DomainModelBase
    {
        public DateTimeOffset TransactionDate { get; set; }

        public DateTimeOffset DueDate { get; set; }

        public string Description { get; set; }

        public bool InvoicePaymentStatus { get; set; }

        public Customer Customer { get; set; }

        public int CustomerId { get; set; }

        public InvoicePayment InvoicePayment { get; set; }

        public int InvoicePaymentId { get; set; }

        public List<ChartOfAccounts> ChartOfAccounts { get; set; }

        public List<OrderSales> Orders { get; set; }

        public List<BookingSales> Bookings { get; set; }
    }
}
