using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public virtual List<ChartOfAccounts> ChartOfAccounts { get; set; }

        public virtual List<OrderSales> Orders { get; set; }

        public virtual List<BookingSales> Bookings { get; set; }
    }
}
