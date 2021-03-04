using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManager.Shared.Abstractions;

namespace RektaManager.Shared
{
    public class Order : DomainModelBase
    {
        public Customer Customer { get; set; }

        public Guid CustomerId { get; set; }

        public List<OrderedItem> OrderedItems { get; set; }

        public ApplicationUser Staff { get; set; }

        public string StaffId { get; set; }

        public DateTimeOffset OrderDate { get; set; }

        public decimal Total { get; set; }


    }
}
