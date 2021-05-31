using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace RektaManagerApp.Shared
{
    public class ApplicationRole : IdentityRole<string>
    {
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow.LocalDateTime;
        public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.UtcNow.LocalDateTime;
        public bool IsDeleted { get; set; }

        [ConcurrencyCheck, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
