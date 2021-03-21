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
    public class Supplier : DomainModelBase
    {
        public List<Product> SuppliedProducts { get; set; }

        public List<Bill> SupplierBills { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        
        [StringLength(44)]
        [Required]
        public string PhoneNumber { get; set; }

        [Column("xmin")]
        public uint Xmin { get; set; }
    }
}
