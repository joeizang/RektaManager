using System.Collections.Generic;
using System.Threading.Tasks;
using RektaManager.Shared.Abstractions;
using RektaManager.Shared.ComponentModels.Invoices;

namespace RektaManager.Server.Abstractions
{
    public interface IInvoiceRepository : IRepository
    {
        Task<IEnumerable<InvoiceComponentModel>> Get(RequestCustomizer query = null);
    }
}
