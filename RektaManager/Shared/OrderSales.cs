using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManager.Shared.Abstractions;

namespace RektaManager.Shared
{
    public class OrderSales : DomainModelBase
    {
        public Invoice Invoice { get; set; }

        public Guid InvoiceId { get; set; }

        public Order Order { get; set; }

        public Guid OrderId { get; set; }
    }
}
