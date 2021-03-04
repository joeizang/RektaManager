using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManager.Shared.Abstractions;

namespace RektaManager.Shared
{
    public class MoneySpent : DomainModelBase
    {
        public DateTimeOffset TransactionDate { get; set; }

        public string Description { get; set; }

        public string Reference { get; set; }

        public decimal Total { get; set; }

        public Guid SupplierId { get; set; }

        public Supplier Supplier { get; set; }

        public List<ChartOfAccounts> ChartOfAccounts { get; set; }

    }
}
