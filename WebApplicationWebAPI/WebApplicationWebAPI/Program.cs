﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WebApplicationWebAPI.Persistence.Contexts;

namespace WebApplicationWebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //  CreateWebHostBuilder(args).Build().Run();
            var host = BuildWebHost(args);

            using (var scope = host.Services.CreateScope())
            using (var context = scope.ServiceProvider.GetService<AppDbContext>())
            {
                context.Database.EnsureCreated();
            }

            host.Run();
        }
        public static IWebHost BuildWebHost(string[] args) =>
           WebHost.CreateDefaultBuilder(args)
           .UseStartup<Startup>()
           .Build();

        //public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //    WebHost.CreateDefaultBuilder(args)
        //        .UseStartup<Startup>();
    }
}
