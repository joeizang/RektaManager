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
    public class Service : DomainModelBase
    {
        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "decimal(20,2)")]
        public decimal Price { get; set; }

    }
}
