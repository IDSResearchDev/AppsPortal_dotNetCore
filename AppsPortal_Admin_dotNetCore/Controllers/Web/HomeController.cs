using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppsPortal.Admin.dotNetCore.Repositories;

namespace AppsPortal.Admin.dotNetCore.Controllers.Web
{
    public class HomeController : Controller
    {
        private IAppRepository _appRepository;

        public HomeController(IAppRepository appRepository)
        {
            _appRepository = appRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FlotCharts()
        {
            return View();
        }

        public IActionResult Slides()
        {
            return View();
        }

        public IActionResult Apps()
        {
            var data = _appRepository.GetAllApplications();
            return View(data);
        }

        public IActionResult Stats()
        {
            return View();
        }

        public IActionResult Users()
        {
            return View();
        }
    }
}
