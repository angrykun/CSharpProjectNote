using System;
using System.Net.Http;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcServiceDemo;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            #region 开发环境中未配置SSL证书，无法正常启动，此配置为忽略无效证书
            //gRPC是基于Http 2.0 必须使用HTTPS故必须配置SSL证书；
            //生产环境中必须使用SSL证书
            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
            var httpClient = new HttpClient(httpClientHandler);
            #endregion

            // The port number(5001) must match the port of the gRPC server.
            //using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            using var channel = GrpcChannel.ForAddress("https://localhost:5001", new GrpcChannelOptions() { HttpClient = httpClient });
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient 张三" });
            Console.WriteLine("Greeter服务返回数据: " + reply.Message);

            var catClient = new LuCat.LuCatClient(channel);
            var catReply = await catClient.SuckingCatAsync(new SuckingCatRequest { Name = " cat 李四" });
            Console.WriteLine("LuCat服务返回数据: " + catReply.Message);
            Console.ReadKey();
        }
    }
}
