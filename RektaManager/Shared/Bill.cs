using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManager.Shared.Abstractions;

namespace RektaManager.Shared
{
    public class Bill : DomainModelBase
    {
        public DateTimeOffset TransactionDate { get; set; }

        public DateTimeOffset DueDate { get; set; }

        public string Description { get; set; }

        public string References { get; set; }

        public decimal Total { get; set; }

        public bool PaymentStatus { get; set; }

        public List<ChartOfAccounts> ChartOfAccounts { get; set; }

        public Guid ChartOfAccountsId { get; set; }

        public Supplier Supplier { get; set; }

        public Guid SupplierId { get; set; }

        public BillPayment BillPayment { get; set; }

        public Guid BillPaymentId { get; set; }
    }
}
