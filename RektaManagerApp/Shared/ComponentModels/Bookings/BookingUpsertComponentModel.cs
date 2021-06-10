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
        public DateTimeOffset BookingDate { get; set; }

        public decimal Deposit { get; set; }

        public decimal Total { get; set; }

        public DateTimeOffset EventDate { get; set; }

        public string StaffUsername { get; set; }

        public string CustomerName { get; set; }


    }
}
