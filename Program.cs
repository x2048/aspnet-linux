using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace WebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>();
                
            if (args.Contains("c9"))
            {
                builder = builder.UseUrls("http://0.0.0.0:8080");
            }
            
            var host = builder.Build();

            host.Run();
        }
    }
}
