using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace WebAppMVCBasic
{
    public class Startup

    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940




        public void ConfigureServices(IServiceCollection services)

        {
            services.AddDistributedMemoryCache();


            services.AddSession(options =>
            {
                options.Cookie.Name = ".AdventureWorks.Session";
                options.IdleTimeout = TimeSpan.FromMinutes(10);
                options.Cookie.IsEssential = true;
            });

            services.AddSession();
            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSession();
            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                 name: "Sledge_route",
                 template: "Kälk-Hockey",
                 defaults: new { controller = "Home", action = "Sledge" });

                routes.MapRoute(
                 name: "Index_route",
                 template: "Om",
                 defaults: new { controller = "Home", action = "Index" });

                routes.MapRoute(
                    name: "fever_route",
                    template: "Feber",
                    defaults: new { controller = "Home", action = "Fever" });

                routes.MapRoute(
                  name: "Gues_route",
                  template: "Gissa",
                  defaults: new { controller = "Home", action = "Gues" });

               

                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
