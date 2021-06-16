using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManager.Shared.Abstractions
{
    public abstract class DomainModelBase : IDomainModel
    {
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow.LocalDateTime;

        public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.UtcNow.LocalDateTime;

        [StringLength(100)]
        public string CreatedBy { get; set; }

        [StringLength(100)]
        public string UpdatedBy { get; set; }

        [Key]
        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        [ConcurrencyCheck, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Timestamp]
        public DateTime Timestamp { get; set; }
    }
}
