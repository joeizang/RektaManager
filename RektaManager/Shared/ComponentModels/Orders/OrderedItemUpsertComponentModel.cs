﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManager.Shared.Abstractions;

namespace RektaManager.Shared.ComponentModels.Orders
{
    public class OrderedItemUpsertComponentModel : BaseUpsertComponentModel
    {
        [Required]
        [StringLength(100)]
        public string ItemName { get; set; }

        [Required]
        public decimal ItemPrice { get; set; }

        [Required]
        [StringLength(10)]
        public string ItemCode { get; set; }

        [Required]
        [Range(typeof(double),"1","5000", ErrorMessage = "You cannot have a quantity of 0 for an Order")]
        public double Quantity { get; set; }
    }
}
