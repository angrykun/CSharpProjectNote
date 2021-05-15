/************************************************************************************ 
 * Copyright (c) 2021 上海浅银互联网科技有限公司 版权所有 All Rights Reserved.
 * 文件名：  ConsulDemo.Controller.ValuesController 
 * 版本号：  V1.0.0.0 
 * 创建人：wangkun
 * 电子邮箱：wangkun@qianyinkeji.cn
 * 创建时间：2021-05-15 18:57:30 
 * 描述    :
 * =====================================================================
 * 修改时间：2021-05-15 18:57:30 
 * 修改人  ：  
 * 版本号  ：V1.0.0.0 
 * 描述    ：
*************************************************************************************/

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Consul;
using Microsoft.Extensions.Configuration;

namespace ConsulDemo.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IConfiguration configuration;

        public ValuesController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Content(configuration.GetSection("ConnectionStrings:DefaultSetting").Value);
        }

        [HttpGet("/consul")]
        public async Task<string> RequestConsul()
        {
            var consulAddress = configuration.GetSection("ConsulConfig:ConsulAddress").Value;
            using (var consulClient = new ConsulClient(x => x.Address = new Uri(consulAddress)))
            {
                //
                var services = await consulClient.Catalog.Service("ConsulDemo");
                if (services.Response != null && services.Response.Any())
                {
                    var random = new Random();
                    int index = random.Next(services.Response.Length);
                    var service = services.Response.ElementAt(index);
                    using (var client = new HttpClient())
                    {
                        var response =
                            await client.GetStringAsync($"http://{service.ServiceAddress}:{service.ServicePort}/api/values");
                        return $"Time:{DateTime.Now:yyyy-MM-dd HH:mm:ss}From Request Consul :{response}";
                    }
                }
            }

            return await Task.FromResult(string.Empty);
        }
    }
}
