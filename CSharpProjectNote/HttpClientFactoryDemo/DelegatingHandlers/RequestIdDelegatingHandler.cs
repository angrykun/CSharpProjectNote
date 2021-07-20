using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace HttpClientFactoryDemo.DelegatingHandlers
{
    public class RequestIdDelegatingHandler : DelegatingHandler
    {
        //作为扩展点
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("x-guid", Guid.NewGuid().ToString());
            var result = await base.SendAsync(request, cancellationToken);
            return result;
        }
    }
}
