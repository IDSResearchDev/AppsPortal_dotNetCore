using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppsPortalCore.Model
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllVersionsByApplication();
        Task<IEnumerable<Product>> GetAllProducts();
    }
}