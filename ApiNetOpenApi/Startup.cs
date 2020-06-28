using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiNetGenerationImageServiceBase;
using ApiNetGenerationImageServiceImplementation;
using ApiNetPGGANServiceBase;
using ApiNetPGGANServiceImpl;
using ApiNetPolygonalModelingServiceBase;
using ApiNetPolygonalModelingServiceImpl;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OpenApiSqlDomain.Entity_Framework;
using OpenApiSqlDomain.Interfaces;

namespace ApiNetOpenApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IGenerationImageService, GenerationImageService>();
            services.AddScoped<IPGGANService, PGGANService>();
            services.AddScoped<IPolygonalModelingService, PolygonalModelingService>();
            services.AddSingleton<IRepository>(repo => new SQLRepository("Diplom"));
            //services.AddScoped<IGenerationImageService, GenerationImageService>();
            services.AddControllers();
            services.AddOpenApiDocument();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // Swagger:
            app.UseOpenApi(); // serve OpenAPI/Swagger documents
            app.UseSwaggerUi3(); // serve Swagger UI
	        app.UseReDoc(); // serve ReDoc UI
        }
    }
}
