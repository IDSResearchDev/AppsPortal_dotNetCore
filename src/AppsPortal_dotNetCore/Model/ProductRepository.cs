using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppsPortal_dotNetCore.Model
{
    public class ProductRepository : IProductRepository
    {
        private ProductContext _context;

        public ProductRepository(ProductContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            var data = _context.Products
                .OrderBy(o => o.Id).ToList();

            return await Task.FromResult(data);
        }

        //public Task<List<Product>> GetAllProducts()
        //{
        //    var data = _context.Products
        //        .OrderBy(o => o.Id).ToListAsync();

        //    return data;
        //}
         

        public async Task<IEnumerable<Product>> GetAllVersionsByApplication()
        {
            var a = _context.Products
                .Include(i => i.ReleaseData)
                .OrderBy(o => o.Id).ToList();


            return await Task.FromResult(a);


            //return ada;
        }


    }
}
