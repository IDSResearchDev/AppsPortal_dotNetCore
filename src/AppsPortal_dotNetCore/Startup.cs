using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppsPortal_dotNetCore.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace AppsPortal_dotNetCore
{
    public class Startup
    {
        private IHostingEnvironment _env;
        private IConfigurationRoot _config;

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

            //Context
            services.AddDbContext<ProductContext>();
            services.AddTransient<ProductContextSeedData>();

            //Repository
            services.AddScoped<IProductRepository, ProductRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory, ProductContextSeedData seeder)
        {
            //    loggerFactory.AddConsole();

            //    if (env.IsDevelopment())
            //    {
            //        app.UseDeveloperExceptionPage();
            //    }

            //    app.Run(async (context) =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //

            //app.UseDefaultFiles();


            if (_env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();
                loggerFactory.AddDebug(LogLevel.Information);
            }
            else
            {
                loggerFactory.AddDebug(LogLevel.Error);
            }

            app.UseStaticFiles();

            app.UseMvc(config => {
                config.MapRoute(
                    name: "Default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "App", action = "Index" }

                    );
            });
            
            seeder.EnsureSeedData().Wait();

        }
    }
}
