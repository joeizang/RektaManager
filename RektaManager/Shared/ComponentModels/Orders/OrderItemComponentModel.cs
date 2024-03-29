﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManager.Shared.ComponentModels.Orders
{
    public class OrderItemComponentModel
    {
        [StringLength(250)]
        public string ImageUrl { get; set; }

        [Column(TypeName = "decimal(20,2)")]
        [Required]
        public decimal Price { get; set; }

        [Column(TypeName = "float(6,2)")]
        [Required]
        public float Quantity { get; set; }

        [Required]
        [StringLength(100)]
        public string ItemName { get; set; }

        public int Id { get; set; }
    }
}
