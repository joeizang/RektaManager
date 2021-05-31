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
    public class ChartOfAccounts : DomainModelBase
    {
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        public  List<Invoice> Invoices { get; set; }

        public  List<Bill> Bills { get; set; }

    }
}
