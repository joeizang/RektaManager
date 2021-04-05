using System.Collections.Generic;
using System.Threading.Tasks;
using RektaManager.Shared;
using RektaManager.Shared.Abstractions;
using RektaManager.Shared.ComponentModels.Products;

namespace RektaManager.Server.Abstractions
{
    public interface IProductRepository : IRepository
    {
        Task<Product> GetProductBy(string searchTerm);

        Task<IEnumerable<ProductComponentModel>> Get(RequestCustomizer query = null);

        Task Update(ProductUpsertComponentModel entity);
    }
}
