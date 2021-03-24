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
    public class OrderedItem : DomainModelBase
    {
        public Order OwningOrder { get; set; }

        public int OrderId { get; set; }

        [Required]
        [Column(TypeName = "decimal(20,2)")]
        public decimal Price { get; set; }

        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        [Required]
        public double Quantity { get; set; }

        [Required]
        [StringLength(10)]
        public string ItemCode { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
