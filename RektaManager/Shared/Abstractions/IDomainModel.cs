using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManager.Shared.Abstractions
{
    public interface IDomainModel
    {
        DateTimeOffset CreatedAt { get; set; }

        DateTimeOffset UpdatedAt { get; set; }

        Guid Id { get; set; }

        bool IsDeleted { get; set; }
    }
}
