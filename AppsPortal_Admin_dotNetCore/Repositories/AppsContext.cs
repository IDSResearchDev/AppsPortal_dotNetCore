using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using AppsPortal.Entities.Model;
using Microsoft.EntityFrameworkCore;

namespace AppsPortal.Admin.dotNetCore.Repositories
{
    public class AppsContext : DbContext
    {
        private IConfigurationRoot _config;

        public AppsContext(IConfigurationRoot config, DbContextOptions options) : base(options)
        {
            _config = config;
        }
        
        
        public DbSet<Apps> Apps { get; set; }
        public DbSet<AppFeature> AppFeatures { get; set; }
        public DbSet<AppDoc> AppDocs { get; set; }
        public DbSet<Slides> Slides { get; set; }
        public DbSet<Buttons> Buttons { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Users> UserDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(_config["ConnectionStrings:AppsContextConnection"]);
        }

    }
}
