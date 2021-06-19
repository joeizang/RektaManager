using RektaManagerApp.Shared.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManagerApp.Shared.ComponentModels.Bookings
{
    public class BookingUpsertComponentModel : BaseUpsertComponentModel
    {
        [Required]
        public DateTime BookingDate { get; set; }

        [Required]
        public decimal Deposit { get; set; }

        public decimal Total { get; set; }

        [Required]
        public DateTime EventDate { get; set; }

        [Required]
        public string StaffUsername { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerName { get; set; }

        [StringLength(300)]
        [Required]
        public string Description { get; set; }

        public bool IsPartPaid { get; set; }

        [Required]
        public bool IsFullyPaid { get; set; }

        public List<int> BookedItems { get; set; }

        public List<int> BookedServices { get; set; }
    }
}
