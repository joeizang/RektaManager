using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManagerApp.Shared.ComponentModels.Suppliers
{
    public class SupplierSelectModel
    {
        public int SupplierId { get; set; }

        public string SupplierName { get; set; }

    }

    public class SupplierComponentModel
    {
        public int SupplierId { get; set; }

        public string SupplierName { get; set; }

        public string PhoneNumber { get; set; }

        public int NumberOfBillsSubmitted { get; set; }

        public int NumberOfProductsSupplied { get; set; }
    }
}
