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
    public class OrderItem : DomainModelBase
    {
        [StringLength(250)]
        public string ImageUrl { get; set; }

        [Column(TypeName = "decimal(20,2)")]
        [Required]
        public decimal Price { get; set; }

        [Required]
        [StringLength(100)]
        public string ItemName { get; set; }

        [Required]
        [StringLength(10)]
        public string ItemCode { get; set; }

    }
}
