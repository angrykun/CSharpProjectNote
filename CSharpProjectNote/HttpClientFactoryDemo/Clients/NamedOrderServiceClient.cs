using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientFactoryDemo.Clients
{
    public class NamedOrderServiceClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private const string _clientName = "NamedOrderServiceClient";//定义客户端名称

        public NamedOrderServiceClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<string> Get()
        {
            //使用客户端名称获取客户端
            var client = _httpClientFactory.CreateClient(_clientName);
            //使用相对路径访问
            return await client.GetStringAsync("/api/OrderService");
        }

    }
}
