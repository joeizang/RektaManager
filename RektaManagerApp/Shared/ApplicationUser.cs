using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using RektaManagerApp.Shared.Abstractions;

namespace RektaManagerApp.Shared
{
    public class ApplicationUser : IdentityUser
    {
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow.LocalDateTime;
        public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.UtcNow.LocalDateTime;
        public bool IsDeleted { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string OtherNames { get; set; }

        public string StaffIdNumber { get; set; }

        [ConcurrencyCheck]
        [Timestamp]
        public byte[] Timestamp { get; set; }

        public List<Order> ProcessedOrders { get; set; }

        public List<Booking> HandledBookings { get; set; }

        public List<StaffShift> StaffShifts { get; set; }
    }
}
