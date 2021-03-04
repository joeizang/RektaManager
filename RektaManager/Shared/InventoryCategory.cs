using System.ComponentModel.DataAnnotations;
using RektaManager.Shared.Abstractions;

namespace RektaManager.Shared
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