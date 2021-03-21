using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManager.Shared.Abstractions;

namespace RektaManager.Shared
{
    public class OrderSales : DomainModelBase
    {
        public Invoice Invoice { get; set; }

        public int InvoiceId { get; set; }

        public Order Order { get; set; }

        public int OrderId { get; set; }

        [Column("xmin")]
        public uint Xmin { get; set; }
    }
}
