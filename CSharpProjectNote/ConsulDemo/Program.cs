using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;
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
        #region 单服务配置
                //.ConfigureAppConfiguration(builder =>
                //{
                //       builder.AddConsul(
                //               "appsettings..json",
                //               options =>
                //               {
                //                   options.ConsulConfigurationOptions =
                //                       cco => { cco.Address = new Uri("http://192.168.217.128:8500"); };
                //                   options.Optional = true;
                //                   options.PollWaitTime = TimeSpan.FromSeconds(5);
                //                   options.ReloadOnChange = true;
                //               })
                //           .AddEnvironmentVariables();
                //}) 
        #endregion

                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureAppConfiguration((hostingContext, config) =>
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

                            #region 若每个服务需要多个配置文件，则添加多个Consul
                            //config.AddConsul($"{env.ApplicationName}/appsettings.{env.EnvironmentName}.json",
                            //    options =>
                            //    {
                            //        options.Optional = true;
                            //        options.ReloadOnChange = true;
                            //        options.OnLoadException = exceptionContext =>
                            //        {
                            //            exceptionContext.Ignore = true;
                            //        };
                            //        options.ConsulConfigurationOptions = cco => { cco.Address = new Uri(consulUrl); };

                            //    }); 
                            #endregion

                            hostingContext.Configuration = config.Build();
                        })
                    .UseStartup<Startup>();
                });
    }
}
