using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppsPortalCore.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AppsPortalCore.Controllers.Web
{
    public class AppController : Controller
    {

        private IConfigurationRoot _config;
        private IProductRepository _repository;
        private ILogger<AppController> _logger;

        public AppController(IProductRepository repository, IConfigurationRoot config, ILogger<AppController> logger)
        {
            _repository = repository;
            _config = config;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var data = _repository.GetAllProducts();
            return View(data);

        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

    }
}
