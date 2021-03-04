using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using RektaManager.Shared.Abstractions;

namespace RektaManager.Shared
{
    public class ApplicationUser : IdentityUser
    {
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string OtherNames { get; set; }

        public string StaffIdNumber { get; set; }

        public List<Order> ProcessedOrders { get; set; }

        public List<Booking> HandledBookings { get; set; }

        public List<StaffShift> StaffShifts { get; set; }
    }
}
