using RektaManagerApp.Shared.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManagerApp.Shared.ComponentModels.Bookings
{
    public class BookingUpsertComponentModel : BaseUpsertComponentModel
    {
        public DateTime BookingDate { get; set; }

        public decimal Deposit { get; set; }

        public decimal Total { get; set; }

        public DateTime EventDate { get; set; }

        public string StaffUsername { get; set; }

        public string CustomerName { get; set; }

        public string Description { get; set; }

        public bool IsPartPaid { get; set; }

        public bool IsFullyPaid { get; set; }

        public List<int> BookedItems { get; set; }

        public List<int> BookedServices { get; set; }
    }
}
