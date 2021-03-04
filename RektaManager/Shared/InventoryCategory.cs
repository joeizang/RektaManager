using RektaManager.Shared.Abstractions;

namespace RektaManager.Shared
{
    public class InventoryCategory : DomainModelBase
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}