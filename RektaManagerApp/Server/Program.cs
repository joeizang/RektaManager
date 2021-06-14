using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RektaManagerApp.Server.Extensions;
using RektaManagerApp.Shared;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RektaManagerApp.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var serviceContainer = scope.ServiceProvider;
                try
                {
                    var roleManager = serviceContainer.GetRequiredService<RoleManager<ApplicationRole>>();
                    var userManager = serviceContainer.GetRequiredService<UserManager<ApplicationUser>>();
                    SeedApplicationUsers.SeedAppUsers(userManager, roleManager).Wait();
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                }
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
