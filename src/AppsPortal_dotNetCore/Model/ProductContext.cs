using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AppsPortal_dotNetCore.Model
{
    public class ProductContext : DbContext
    {
        private IConfigurationRoot _config;

        public ProductContext(IConfigurationRoot config, DbContextOptions options) : base(options)
        {
            _config = config;
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductRelease> ProductReleases { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(_config["ConnectionStrings:ProductContextConnection"]);
        }

    }
}
