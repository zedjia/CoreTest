using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp1
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            //app.UseOwin(x => x.UseNancy(o => {
            //    o.Bootstrapper = new ProgramBootstrapper(builder => {
            //        var configuration = new ConfigurationBuilder()
            //            .AddEnvironmentVariables()
            //            .Build();
            //        var config = new LiGetEnvironmentConfig(configuration);
            //        builder.RegisterModule(new NuGetServerAutofacModule(config));
            //        builder.RegisterModule(new CachingProxyAutofacModule(config));
            //        builder.RegisterModule(new DBreezeCacheAutofacModule(config));
            //    });
            //}));
        }
    }
}
