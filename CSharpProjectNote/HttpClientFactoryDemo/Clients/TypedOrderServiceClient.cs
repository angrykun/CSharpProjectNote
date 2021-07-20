using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientFactoryDemo.Clients
{
    public class TypedOrderServiceClient
    {
        /// <summary>
        /// httpClient会从HttpClientFactory中获取
        /// </summary>
        private readonly HttpClient _client;

        public TypedOrderServiceClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<string> Get()
        {
            return await _client.GetStringAsync("/api/OrderService");
        }
    }
}
