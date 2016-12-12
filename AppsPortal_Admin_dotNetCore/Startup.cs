using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using AppsPortal.Admin.dotNetCore.Repositories;
using AutoMapper;
using AppsPortal.Admin.dotNetCore.ViewModel;
using AppsPortal.Entities.Model;

namespace AppsPortal.Admin.dotNetCore
{
    public class Startup
    {
        private IConfigurationRoot _config;
        private IHostingEnvironment _env;

        public Startup(IHostingEnvironment env)
        {
            _env = env;

            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("config.json")
                .AddEnvironmentVariables();

            _config = builder.Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(_config);
            services.AddLogging();
            services.AddMvc();

            services.AddDbContext<AppsContext>();

            services.AddScoped<IAppRepository, AppRepository>();
            services.AddTransient<AppsContextSeedData>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory, AppsContextSeedData seeder)
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<AppsViewModel, Apps>().ReverseMap();
                config.CreateMap<SlidesViewModel, Slides>().ReverseMap();
            });
            loggerFactory.AddConsole();

            if (_env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvc(config => 
            {
                config.MapRoute(
                        name: "Default",
                        template: "{controller}/{action}/{id?}",
                        defaults: new { controller = "Home", action = "Index"}
                    );
            });


            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
            seeder.EnsureSeedData().Wait();
        }
    }
}
