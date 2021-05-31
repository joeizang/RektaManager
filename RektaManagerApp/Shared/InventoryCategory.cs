using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RektaManagerApp.Shared.Abstractions;

namespace RektaManagerApp.Shared
{
    public class InventoryCategory : DomainModelBase
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }
    }
}