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
    public class Order : DomainModelBase
    {
        public Customer Customer { get; set; }

        public int CustomerId { get; set; }

        public  List<OrderedItem> OrderedItems { get; set; }

        public float OrderedItemsCount { get; set; }

        public ApplicationUser Staff { get; set; }

        public string StaffId { get; set; }

        [Required]
        public DateTimeOffset OrderDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(20,2)")]
        public decimal Total { get; set; }

        public List<OrderSales> OrderSalesInvoices { get; set; }

        public int InvoiceId { get; set; }

        public Order()
        {
            OrderSalesInvoices = new List<OrderSales>();
            OrderedItems = new List<OrderedItem>();
            OrderedItemsCount = OrderedItems.Count;
        }

    }
}
