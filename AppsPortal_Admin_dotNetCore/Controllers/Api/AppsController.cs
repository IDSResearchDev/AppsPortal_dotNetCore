using AppsPortal.Admin.dotNetCore.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AppsPortal.Admin.dotNetCore.ViewModel;

namespace AppsPortal.Admin.dotNetCore.Controllers.Api
{
    [Route("api/apps")]
    public class AppsController : Controller
    {
        private IAppRepository _repository;

        public AppsController(IAppRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("")]
        public IActionResult GetAllApp()
        {
            try
            {
                var results = _repository.GetAllApplications();

                return Ok(Mapper.Map<IEnumerable<AppsViewModel>>(results));
            }
            catch (Exception ex)
            {
                //_logger.LogError($"Failed to get All Trips: {ex}");
                Console.Write(ex);
                return BadRequest("Error occurred");
            }
        }

        [HttpGet("/api/apps/{appTitle}")]
        public IActionResult GetApp(string appTitle)
        {
            try
            {
                var app = _repository.GetApplication(appTitle);

                return Ok(Mapper.Map<AppsViewModel>(app));
            }
            catch (Exception ex)
            {
                //_logger.LogError($"Failed to get All Trips: {ex}");
                Console.Write(ex);
                return BadRequest("Error occurred");
            }
        }
    }
}
