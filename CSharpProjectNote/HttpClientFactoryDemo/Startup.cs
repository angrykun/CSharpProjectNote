using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HttpClientFactoryDemo.Clients;
using HttpClientFactoryDemo.DelegatingHandlers;

namespace HttpClientFactoryDemo
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
            services.AddControllers();


            //注册HttpClient客户端,工厂模式
            services.AddHttpClient();
            services.AddScoped<OrderServiceClient>();

            //命名客户端模式
            //基于命名客户端，我们可以为不同的服务配置不同的客户端
            //1.可以为不同的请求配置不同的Header、BaseAddress
            //2.不同的配置是独立管理内部的HttpHandler生命周期，意味着Socket资源是独立管理的
            services.AddSingleton<RequestIdDelegatingHandler>();
            services.AddHttpClient("NamedOrderServiceClient", client =>
            {
                client.BaseAddress = new Uri("http://localhost:5002");
                client.DefaultRequestHeaders.Add("client-name", "namedClient");
            }).SetHandlerLifetime(TimeSpan.FromMinutes(2))
                .AddHttpMessageHandler(provider => provider.GetService<RequestIdDelegatingHandler>());
            services.AddScoped<NamedOrderServiceClient>();

            //类型客户端模式
            //实际开发中，建议使用类型客户端模式
            //可以配置不同的生命周期及管道模型
            //可设置不同的BaseAddress等
            services.AddHttpClient<TypedOrderServiceClient>(client =>
            {
                client.BaseAddress = new Uri("http://localhost:5002");
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
