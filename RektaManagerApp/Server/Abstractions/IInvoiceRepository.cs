using System.Collections.Generic;
using System.Threading.Tasks;
using RektaManagerApp.Shared.Abstractions;
using RektaManagerApp.Shared.ComponentModels.Invoices;

namespace RektaManagerApp.Server.Abstractions
{
    public interface IInvoiceRepository : IRepository
    {
        Task<IEnumerable<InvoiceComponentModel>> Get(RequestCustomizer query = null);
    }
}
