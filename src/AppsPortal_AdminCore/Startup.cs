﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;

namespace AppsPortal.AdminCore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940

        /// <summary>
        /// shawn wildermuth pattern
        /// **** having config.json / inserting environment on startup / adding configurationroot on startup
        /// </summary>
        /// <param name="services"></param>
        //private IHostingEnvironment _env;
        //private IConfigurationRoot _config;

        //public Startup(IHostingEnvironment env)
        //{
        //    _env = env;

        //    var builder = new ConfigurationBuilder()
        //        .SetBasePath(_env.ContentRootPath);
        //        .AddJsonFile("config.json")
        //        .AddEnvironmentVariables();

        //    _config = builder.Build();

        //}

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging();

            services
                .AddMvc()
                /*.AddJsonOptions(json => {
                    json.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                })*/;

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            

            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                loggerFactory.AddDebug(LogLevel.Information);
            }
            else
            {
                loggerFactory.AddDebug(LogLevel.Error);
            }
            
            app.UseStaticFiles();

            app.UseMvc(config =>
            {
                config.MapRoute
                (
                    name: "Default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new {controller = "App", action="Index"}
                );
            });
        }
    }
}
