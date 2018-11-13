using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .UseUrls("http://*:9080")
                .Build()
                ;

            host.Run();
            Console.ReadLine();
        }
    }
}
