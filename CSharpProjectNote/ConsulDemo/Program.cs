using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Winton.Extensions.Configuration.Consul;

namespace ConsulDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    var env = hostingContext.HostingEnvironment;
                    hostingContext.Configuration = config.Build();
                    var consulUrl = hostingContext.Configuration["ConsulConfig:ConsulAddress"];
                    config.AddConsul($"{env.ApplicationName}/appsettings.{env.EnvironmentName}.json",
                        options =>
                        {
                            options.Optional = true;
                            options.ReloadOnChange = true;
                            options.OnLoadException = exceptionContext =>
                            {
                                exceptionContext.Ignore = true;
                            };
                            options.ConsulConfigurationOptions = cco => { cco.Address = new Uri(consulUrl); };

                        });
                    hostingContext.Configuration = config.Build();
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
