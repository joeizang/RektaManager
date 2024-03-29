﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManager.Shared.Abstractions;

namespace RektaManager.Shared
{
    public class InvoicePayment : DomainModelBase
    {
        public DateTimeOffset TransactionDate { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        [StringLength(150)]
        public string Reference { get; set; }

        [Column(TypeName = "decimal(20,2)")]
        public decimal Total { get; set; }

        public  List<Invoice> Invoices { get; set; }
    }
}
