using System.Collections.Generic;
using System.Threading.Tasks;
using RektaManagerApp.Shared;
using RektaManagerApp.Shared.Abstractions;
using RektaManagerApp.Shared.ComponentModels.Products;

namespace RektaManagerApp.Server.Abstractions
{
    public interface IProductRepository : IRepository
    {
        Task<Product> GetProductBy(string searchTerm);

        Task<IEnumerable<ProductComponentModel>> Get(RequestCustomizer query = null);

        Task Update(ProductUpsertComponentModel entity);
    }
}
