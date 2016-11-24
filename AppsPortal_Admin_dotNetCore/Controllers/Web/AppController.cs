using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AppsPortal.Admin.dotNetCore.Controllers.Web
{
    public class AppController : Controller
    {
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

        public IActionResult Applications()
        {
            
            return View();
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
