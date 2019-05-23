using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace MVCApp
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            /*app.Use(async (c,next)=>
            {
                logger.LogInformation("MW1: incoming request ");
                //await c.Response.WriteAsync("Hello World!!");
                await next();
                logger.LogInformation("MW1: outgoing response ");
            });
            app.Use(async (c,next)=>
            {
                logger.LogInformation("MW2: incoming request ");
                //await c.Response.WriteAsync("Hello World!!");
                await next();
                logger.LogInformation("MW2: outgoing response ");
            });*/
            app.UseDefaultFiles("/wwwroot/foo.html");
            app.UseStaticFiles();
            app.Run(async (c)=>
            {
                logger.LogInformation("request handled");
                await c.Response.WriteAsync($"{System.Diagnostics.Process.GetCurrentProcess().ProcessName} - {Configuration["MyKey"]}");
            });
            app.Run(async (c)=>
            {
                await c.Response.WriteAsync("Hello World!!");
            });
            /*else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc();*/
        }
    }
}
