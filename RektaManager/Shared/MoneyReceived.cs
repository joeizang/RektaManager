using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManager.Shared.Abstractions;

namespace RektaManager.Shared
{
    public class MoneyReceived : DomainModelBase
    {
        public DateTimeOffset TransactionDate { get; set; }

        public string Description { get; set; }

        public string Reference { get; set; }

        public decimal Total { get; set; }

        public Customer Customer { get; set; }

        public Guid CustomerId { get; set; }

        public List<ChartOfAccounts> ChartOfAccounts { get; set; }

    }
}
