using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManagerApp.Shared.Abstractions
{
    public interface IDomainModel
    {
        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset UpdatedAt { get; set; }

        public string CreatedBy { get; set; }

        public string UpdatedBy { get; set; }

        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        byte[] Timestamp { get; set; }
    }
}
