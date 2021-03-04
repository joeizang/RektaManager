using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManager.Shared.Abstractions;

namespace RektaManager.Shared
{
    public class InvoicePayment : DomainModelBase
    {
        public DateTimeOffset TransactionDate { get; set; }

        public string Description { get; set; }

        public string Reference { get; set; }

        public decimal Total { get; set; }

        public ChartOfAccounts ChartOfAccounts { get; set; }

        public Guid ChartOfAccountsId { get; set; }

        public List<Invoice> Invoices { get; set; }
    }
}
