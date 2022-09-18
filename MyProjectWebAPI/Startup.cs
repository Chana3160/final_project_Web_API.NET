using BL;
using DL;
using Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProjectWebAPI
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
            services.AddAutoMapper(typeof(Startup));

            services.AddScoped(typeof(IUserBL), typeof(UserBL));
            services.AddScoped(typeof(IUserDL), typeof(UserDL));
            services.AddScoped(typeof(IProductBL), typeof(ProductBL));
            services.AddScoped(typeof(IProductDL), typeof(ProductDL));
            services.AddScoped(typeof(ICategoryBL), typeof(CategoryBL));
            services.AddScoped(typeof(ICategoryDL), typeof(CategoryDL));
            services.AddScoped(typeof(IOrderBL), typeof(OrderBL));
            services.AddScoped(typeof(IOrderDL), typeof(OrderDL));
            services.AddControllers();
            services.AddDbContext<salseContext>(options => options.UseSqlServer(
               Configuration.GetConnectionString("sales")), ServiceLifetime.Scoped);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MyProjectWebAPI", Version = "v1" });
            });

            //services.AddResponseCaching();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> Logger)
        {
            app.UseErrorHandlingMiddleware();
            app.UseRatingMiddleware();
            Logger.LogInformation("server is up");
            Logger.LogError("ooooooops there is an Error");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyProjectWebAPI v1"));
             
            }
            app.UseRouting();
            
            
            
            
            /////
            app.UseErrorHandlingMiddleware();
            
            app.UseStaticFiles();
            app.UseHttpsRedirection();
 
            
            app.UseAuthorization();

            //////////////
            app.Use(async (context, next) =>
            {
                context.Response.GetTypedHeaders().CacheControl =
                new Microsoft.Net.Http.Headers.CacheControlHeaderValue
                {
                    Public = true,
                    MaxAge = TimeSpan.FromSeconds(30)
                };
                context.Response.Headers[Microsoft.Net.Http.Headers.HeaderNames.Vary] =
                new string[] { "Accept-Encoding" };
                await next();
            });



            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


            
        }
    }
}
