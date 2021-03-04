using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManager.Shared.Abstractions;

namespace RektaManager.Shared
{
    public class ChartOfAccounts : DomainModelBase
    {
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        public List<InvoicePayment> InvoicePayments { get; set; }

        public List<Invoice> Invoices { get; set; }

        public List<MoneyReceived> MoniesReceived { get; set; }

        public List<BillPayment> BillPayments { get; set; }

        public List<Bill> Bills { get; set; }

        public List<MoneySpent> SpentMonies { get; set; }
    }
}
