﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManager.Shared.ComponentModels.Inventories
{
    public class InventoryDetailComponentModel
    {
        public List<string> InventoryCategories { get; set; }
        public List<string> ProductNames { get; set; }
        public double InventoryQuantity { get; set; }
        public string InventoryName { get; set; }
        public DateTimeOffset Date { get; set; }
    }
}
