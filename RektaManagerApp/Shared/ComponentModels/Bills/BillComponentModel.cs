using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManagerApp.Shared.ComponentModels.Bills
{
    public class BillComponentModel
    {
        public string BillId { get; set; }
        public DateTimeOffset TransactionDate { get; set; }

        public DateTimeOffset DueDate { get; set; }

        public string Description { get; set; }

        public string References { get; set; }

        public decimal Total { get; set; }

        public bool PaymentStatus { get; set; }

        public int SupplierId { get; set; }

        public string BillPaymentId { get; set; }
    }
}
