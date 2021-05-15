/************************************************************************************ 
 * Copyright (c) 2021 上海浅银互联网科技有限公司 版权所有 All Rights Reserved.
 * 文件名：  ConsulDemo.Extension.ConsulExtensions 
 * 版本号：  V1.0.0.0 
 * 创建人：wangkun
 * 电子邮箱：wangkun@qianyinkeji.cn
 * 创建时间：2021-05-14 23:52:00 
 * 描述    :
 * =====================================================================
 * 修改时间：2021-05-14 23:52:00 
 * 修改人  ：  
 * 版本号  ：V1.0.0.0 
 * 描述    ：
*************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Consul;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace ConsulDemo.Extension
{
    public static class ConsulExtensions
    {
        /// <summary>
        /// 服务注册 consul
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseConsul(this IApplicationBuilder app)
        {
            //获取consul配置实例
            var consulConfig = app.ApplicationServices.GetRequiredService<IOptions<ConsulOptions>>().Value;

            //获取应用程序生命周期
            var lifeTime = app.ApplicationServices.GetRequiredService<IHostApplicationLifetime>();

            //
            var consulClient = new ConsulClient(c =>
            {
                //consul服务注册地址
                c.Address = new Uri(consulConfig.ConsulAddress);
            });

            var registration = new AgentServiceRegistration()
            {
                ID = Guid.NewGuid().ToString(),
                Name = consulConfig.ServiceName,
                Address = consulConfig.ServiceIp,//服务IP
                Port = consulConfig.ServicePort,//服务端口
                Check = new AgentServiceCheck()
                {
                    DeregisterCriticalServiceAfter = TimeSpan.FromSeconds(5), //服务启动多久注册服务
                    Interval = TimeSpan.FromSeconds(10),//健康检车时间间隔
                    HTTP = $"http://{consulConfig.ServiceIp}:{consulConfig.ServicePort}{consulConfig.HealthCheck}",//健康检查地址
                    Timeout = TimeSpan.FromSeconds(5)//超时时间
                }
            };
            //服务注册
            consulClient.Agent.ServiceRegister(registration).Wait();
            lifeTime.ApplicationStopping.Register(() =>
              {
                  consulClient.Agent.ServiceDeregister(registration.ID).Wait();
              });
            return app;
        }
    }
}
