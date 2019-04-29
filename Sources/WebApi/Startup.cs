using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Mmu.Ct.Backend.WebApi.Areas.Application.Settings.Models;
using Mmu.Mlh.WebApiExtensions.Areas.Initialization.AppInitialization.Models;
using Mmu.Mlh.WebApiExtensions.Areas.Initialization.AppInitialization.Services;
using Mmu.Mlh.WebApiExtensions.Areas.Initialization.ServiceInitialization.Models;
using Mmu.Mlh.WebApiExtensions.Areas.Initialization.ServiceInitialization.Services;
using Swashbuckle.AspNetCore.Swagger;

namespace Mmu.Ct.Backend.WebApi
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", false, true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public static void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseSwagger();
            app.UseSwaggerUI(
                c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Container Testing API V1");
                });

            var config = new AppConfig(app, env, loggerFactory);
            AppInitializationService.InitializeApplication(config);
        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            var serviceConfig = new ServiceConfig(services, Configuration, typeof(Startup).Assembly);

            services.AddSwaggerGen(
                c =>
                {
                    c.SwaggerDoc("v1", new Info { Title = "Container Testing API", Version = "v1" });
                });

            return ServiceInitializationService.InitializeServices<WebSettings>(serviceConfig);
        }
    }
}