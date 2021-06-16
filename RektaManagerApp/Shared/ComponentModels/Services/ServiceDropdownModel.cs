using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManagerApp.Shared.ComponentModels.Services
{
    public class ServiceDropdownModel
    {
        public int ServiceId { get; set; }

        public string ServiceName { get; set; }

    }

    public class ServiceComponentModel
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int ServiceId { get; set; }
    }

    public class ServiceUpsertComponentModel
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public DateTime Timestamp { get; set; }

        public int ServiceId { get; set; }

    }
}
