using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManagerApp.Shared.ComponentModels.Bookings
{
    public class BookingComponentModel
    {
        public int BookingId { get; set; }

        public string CustomerName { get; set; }

        public DateTime EventDate { get; set; }

        public DateTime BookingDate { get; set; }

        public bool IsPartPaid { get; set; }

        public bool IsFullyPaid { get; set; }

        public string BookedBy { get; set; }
    }
}
