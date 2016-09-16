using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppsPortal_dotNetCore.Model
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllVersionsByApplication();
        Task<IEnumerable<Product>> GetAllProducts();
    }
}