﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WebApplication4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                                .AddCommandLine(args)
                                .Build();

            var webHost = new WebHostBuilder()
                            .UseKestrel()
                            //.UseConfiguration(config)
                            .UseContentRoot(Directory.GetCurrentDirectory())
                            .UseStartup<Startup>()
                            .UseUrls("http://*:8099")
                            .Build();

            Console.WriteLine("Yahoo you've got a web server running");
            webHost.Run();
            
            Console.WriteLine("Bye bye.");
        }
    }
}
