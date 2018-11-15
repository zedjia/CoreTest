using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace WebApplication4
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


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "wwwroot";
            });
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
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            //app.UseHttpsRedirection();
            app.UseStaticFiles();
            //app.UseCookiePolicy();
            app.UseSpaStaticFiles();
            //app.UseWelcomePage();
            app.UseDefaultFiles();
            app.UseHsts();
            app.UseMvc();

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "wwwroot";

                if (env.IsDevelopment())
                {
                    //spa.use//.UseReactDevelopmentServer(npmScript: "start");
                }
            });


        }


        //public IConfigurationRoot Configuration { get; }

        //public Startup(IHostingEnvironment env)
        //{
        //    Configuration = new ConfigurationBuilder().AddEnvironmentVariables().Build();
        //}

        //public void Configure(IApplicationBuilder app)
        //{
        //    //var directoryToRead = Configuration["dir"] ?? "/";

        //    //Console.WriteLine(directoryToRead);

        //    //if (directoryToRead == null)
        //    //{
        //    //    return;
        //    //}

        //    //// DirectoryInfo di = new DirectoryInfo(directoryToRead);

        //    //// Configure the services etc here
        //    //// app.UseStaticFiles(new StaticFileOptions() {
        //    ////     FileProvider = new PhysicalFileProvider(
        //    ////         Path.Combine(Directory.GetCurrentDirectory(), @"www")
        //    ////     )
        //    //// });
        //    //var fileProvider = new PhysicalFileProvider(
        //    //        directoryToRead
        //    //    );
        //    //app.UseDirectoryBrowser(new DirectoryBrowserOptions()
        //    //{
        //    //    FileProvider = fileProvider
        //    //});
        //    //app.UseStaticFiles(new StaticFileOptions()
        //    //{
        //    //    FileProvider = fileProvider
        //    //});
        //}

        //public IServiceProvider ConfigureServices(IServiceCollection services)
        //{
        //    // Build your service collection here. DI Magic begins here
        //    //return services
        //    //            .AddDirectoryBrowser()
        //    //            .BuildServiceProvider();
        //}
    }

}
