﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManagerApp.Shared.Abstractions;

namespace RektaManagerApp.Shared
{
    public class Invoice : DomainModelBase
    {
        [Key]
        public new string Id { get; set; }

        public DateTimeOffset TransactionDate { get; set; }

        public DateTimeOffset DueDate { get; set; }

        public string Description { get; set; }

        public decimal Total { get; set; }

        public bool FullyPaid { get; set; }

        public Customer Customer { get; set; }

        public int CustomerId { get; set; }

        public InvoicePayment InvoicePayment { get; set; }

        public string InvoicePaymentId { get; set; }

        public List<ChartOfAccounts> ChartOfAccounts { get; set; }

        public List<OrderSales> Orders { get; set; }

        public List<BookingSales> Bookings { get; set; }
    }
}
