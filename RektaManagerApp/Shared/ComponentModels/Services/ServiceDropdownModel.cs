using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManagerApp.Shared.ComponentModels.Services
{
    public class ServiceDropdownModel
    {
        public int ServiceId { get; set; }

        [Display(Name = "Service Name")]
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
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime Timestamp { get; set; }

        [Required]
        public int ServiceId { get; set; }

    }

    public class ServiceSummaryListModel
    {
        public int ServiceId { get; set; }

        public string ServiceName { get; set; }
    }
}
