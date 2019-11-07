using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace CityInfo
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();          //Adding the ASP.NEt Core MVC Middleware
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler();      //Prod. This block will run if the aws env variable in VS was set from develop to prod.
            }

            app.UseStatusCodePages();        // status code page middleware. simple text-based handler added to the request pipeline.
            //This produces a status code 404 not found, because we dont have a startup page.
            app.UseMvc();
            /*
            app.Run(async (context) =>
            {
                //throw new Exception("stuff is broken");
                await context.Response.WriteAsync("Hello Worldeee2.1!");
            });
            */
        }
    }
}
