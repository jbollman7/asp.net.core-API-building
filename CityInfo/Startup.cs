using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;

namespace CityInfo
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                .AddMvcOptions(o => o.OutputFormatters.Add(
                    new XmlDataContractSerializerOutputFormatter()));
            /*
             Below is a fancy way of serializing the output. Meaning, i have the class attriubtes uppercase. By default, the output is in pascal case.
             if i uncomment the below code, it will take it verbatim on how i wrote it. Only needed if it was a aestic requirement. Most likely
             no one cares. 
            
            
            .AddJsonOptions(o => {
               if (o.SerializerSettings.ContractResolver != null)
               {
                    var castedResolver = o.SerializerSettings.ContractResolver
                        as DefaultContractResolver;
                    castedResolver.NamingStrategy = null;
               }

            });              //Adding the ASP.NEt Core MVC Middleware
        */
            
            
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

        }
    }
}
