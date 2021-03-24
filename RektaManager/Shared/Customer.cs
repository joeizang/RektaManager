using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManager.Shared.Abstractions;

namespace RektaManager.Shared
{
    public class Customer : DomainModelBase
    {
        public List<Order> CustomerOrders { get; set; }

        public List<Booking> CustomerBookings { get; set; }

        public List<Invoice> CustomerInvoices { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [StringLength(44)]
        public string PhoneNumber { get; set; }
    }
}
