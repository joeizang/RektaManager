using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManager.Shared.Abstractions
{
    public abstract class DomainModelBase : IDomainModel
    {
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }

        protected DomainModelBase()
        {
            Id = Guid.NewGuid();
        }
    }
}
