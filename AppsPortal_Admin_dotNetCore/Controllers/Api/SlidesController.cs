using AppsPortal.Admin.dotNetCore.Repositories;
using AppsPortal.Admin.dotNetCore.ViewModel;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsPortal.Admin.dotNetCore.Controllers.Api
{
    [Route("api/slides")]
    public class SlidesController : Controller
    {
        private IAppRepository _repository;

        public SlidesController(IAppRepository repository)
        {
            _repository = repository;
        }


        [HttpGet("")]
        public IActionResult GetAllSlides()
        {
            try
            {
                var results = _repository.GetAllSlides();

                return Ok(Mapper.Map<IEnumerable<SlidesViewModel>>(results));
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                return BadRequest("Error occurred");
            }
        }

        [HttpGet("/api/slides/{slideTitle}")]
        public IActionResult GetApp(string slideTitle)
        {
            try
            {
                var slide = _repository.GetSlide(slideTitle);

                return Ok(Mapper.Map<SlidesViewModel>(slide));
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                return BadRequest("Error occurred");
            }
        }
    }
}
