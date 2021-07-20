using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientFactoryDemo.Clients
{
    /// <summary>
    /// 工厂构造模式
    /// </summary>
    public class OrderServiceClient
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public OrderServiceClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<string> Get()
        {
            var client = _httpClientFactory.CreateClient();
            return await client.GetStringAsync("http://localhost:5002/api/OrderService");
        }
    }
}
