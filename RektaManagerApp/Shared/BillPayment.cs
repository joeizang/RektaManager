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
    public class BillPayment : DomainModelBase
    {
        [Key]
        public new string Id { get; set; }
        public DateTimeOffset TransactionDate { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        [StringLength(150)]
        public string Reference { get; set; }

        [Column(TypeName = "decimal(20,2)")]
        public decimal Total { get; set; }

        public List<Bill> Bills { get; set; }
    }
}
