using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HttpClientFactoryDemo.Clients;

namespace HttpClientFactoryDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderServiceClient _orderServiceClient;

        public OrderController(OrderServiceClient orderServiceClient)
        {
            _orderServiceClient = orderServiceClient;
        }

        /// <summary>
        /// 工厂模式
        /// </summary>
        /// <returns></returns>
        [HttpGet("Get")]
        public async Task<string> Get()
        {
            return await _orderServiceClient.Get();
        }

        /// <summary>
        /// 命名客户端
        /// 
        /// </summary>
        /// <param name="namedOrderServiceClient"></param>
        /// <returns></returns>
        [HttpGet("NamedGet")]
        public async Task<string> Get([FromServices] NamedOrderServiceClient namedOrderServiceClient)
        {
            return await namedOrderServiceClient.Get();
        }
    }
}
