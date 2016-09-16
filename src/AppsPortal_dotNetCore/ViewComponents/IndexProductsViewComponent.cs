using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppsPortal_dotNetCore.Model;
using Microsoft.AspNetCore.Mvc;

namespace AppsPortal_dotNetCore.ViewComponents
{
    public class IndexProductsViewComponent : ViewComponent
    {
        private IProductRepository _repository;

        public IndexProductsViewComponent(IProductRepository repo)
        {
            _repository = repo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var products = await _repository.GetAllProducts(); //_productService.GetPromotedProducts();
            return View(products);
        }

    }
}

