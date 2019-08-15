using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkETic.Data;
using DrinkETic.Data.Interfaces;
using DrinkETic.Data.Models;
using DrinkETic.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DrinkETic
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940  
        private IConfigurationRoot _configurationRoot;
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSession();
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));
            services.AddTransient<IDrinkRepository, DrinkRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(s => ShoppingCart.GetCart(s));
            services.AddMvc();
        }
      
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.

        public Startup(IHostingEnvironment hostingEnvironment)
        {
            _configurationRoot = new ConfigurationBuilder().SetBasePath(hostingEnvironment.ContentRootPath).AddJsonFile("appsettings.json").Build();
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //app.Run(async (context) => { await context.Response.WriteAsync("dev"); });
            }
            if (env.IsProduction())
            {
                app.Run(async (context) => { await context.Response.WriteAsync("isProduction"); });
            }

            app.UseStaticFiles();
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseSession();
            app.UseMvcWithDefaultRoute();
            DbInitializer.Seed(app);
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "categoryfilter", template: "Drink/{action}/{category?}",defaults:new {Controller="Drink",Action="List" });
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
            }
            );


            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
