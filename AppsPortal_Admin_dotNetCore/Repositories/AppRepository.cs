using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppsPortal.Entities.Model;

namespace AppsPortal.Admin.dotNetCore.Repositories
{
    public class AppRepository : IAppRepository
    {
        private AppsContext _context;

        public AppRepository(AppsContext context)
        {
            _context = context;
        }

        public IEnumerable<Apps> GetAllApplications()
        {
            var data = _context.Apps
                .OrderBy(o => o.Id).ToList();

            return data;
        }

        public IEnumerable<Slides> GetAllSlides()
        {
            var data = _context.Slides
                 .OrderBy(o => o.Id).ToList();

            return data;
        }

        //public Task<List<Product>> GetAllProducts()
        //{
        //    var data = _context.Products
        //        .OrderBy(o => o.Id).ToListAsync();

        //    return data;
        //}


        public IEnumerable<Apps> GetAllVersionsByApplication()
        {
            var a = _context.Apps
                .Include(i => i.ButtonDetails)
                .Include(f => f.FeedBacks)
                .OrderBy(o => o.Id).ToList();


            return a;


            //return ada;
        }

        public Apps GetApplication(string appTitle)
        {
            var data = _context.Apps
                .Include(i => i.ButtonDetails)
                .Include(f => f.FeedBacks)
                .Where(a => a.Title == appTitle)
                .FirstOrDefault();

            return data;
        }

        public Slides GetSlide(string slideTitle)
        {
            var data = _context.Slides
                .Include(i => i.ButtonDetails)
                .Where(a => a.Title == slideTitle)
                .FirstOrDefault();

            return data;
        }
    }
}
