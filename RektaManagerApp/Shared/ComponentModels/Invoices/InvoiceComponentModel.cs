using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManagerApp.Shared.ComponentModels.Invoices
{
    public class InvoiceComponentModel
    {
        public int InvoiceId { get; set; }

        public string CustomerName { get; set; }

        public DateTimeOffset TransactionDate { get; set; }

        public DateTimeOffset? DueDate { get; set; }

        public bool InvoicePaymentStatus { get; set; }

        public int CustomerId { get; set; }

        public int InvoicePaymentId { get; set; }

        public int? OrderId { get; set; }

        public int? BookingId { get; set; }


    }

    public class InvoiceListComponentModel
    {
        public DateTimeOffset TransactionDate { get; set; }

        public int NumberOfOrders { get; set; }

        public string CustomerName { get; set; }

        public bool InvoicePaymentStatus { get; set; }

        public DateTimeOffset? DueDate { get; set; }

        public int InvoiceId { get; set; }

    }


    public class InvoiceUpsertComponentModel
    {
        [Required]
        public DateTime TransactionDate { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        [StringLength(300)]
        public string Description { get; set; }

        public bool FullyPaid { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerName { get; set; }

        [StringLength(50)]
        public string CustomerPhone { get; set; }

        [Required]
        public decimal Amount { get; set; }

        public decimal Total { get; set; }

        [Required]
        public string AttendingStaff { get; set; }

        public List<int> Services { get; set; } = new();
        
        public List<int> BookedItems { get; set; } = new();

        public List<int> Orders { get; set; } = new();

    }
}
