using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManager.Shared.Abstractions
{
    public abstract class DomainModelBase : IDomainModel
    {
        public DateTimeOffset CreatedAt { get; set; }
        
        public DateTimeOffset UpdatedAt { get; set; }

        [Key]
        public int Id { get; set; }
        
        public bool IsDeleted { get; set; }

        [ConcurrencyCheck]
        [Timestamp]
        public byte[] Timestamp { get; set; }

    }
}
