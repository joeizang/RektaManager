using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManagerApp.Shared.Abstractions;

namespace RektaManagerApp.Shared
{
    public class Bill : DomainModelBase
    {
        public DateTimeOffset TransactionDate { get; set; }

        public DateTimeOffset DueDate { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        [StringLength(150)]
        public string References { get; set; }

        [Column(TypeName = "decimal(20,2)")]
        public decimal Total { get; set; }

        public bool PaymentStatus { get; set; }

        public  List<ChartOfAccounts> ChartOfAccounts { get; set; }

        public int ChartOfAccountsId { get; set; }

        public Supplier Supplier { get; set; }

        public int SupplierId { get; set; }

        public BillPayment BillPayment { get; set; }

        public int BillPaymentId { get; set; }
    }
}
