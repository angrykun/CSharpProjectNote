using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proxy.LearningHard;
using Proxy.LiuWei;

namespace Proxy
{
    /**
     * 代理模式：就是给某一个对象提供一个代理，并由代理对象控制对
     * 源对象的引用，在一些情况下，一个客户不能直接引用另一个对象，
     * 而代理模式可以在客户端和源对象中间起到中介作用。
     * **/
    class Program
    {
        static void Main(string[] args)
        {
            MethodTwo();
        }
        static void MethodOne()
        {
            FriendProxy proxy = new FriendProxy();
            proxy.BuyProduct();

            Console.ReadKey();
        }

        static void MethodTwo()
        {
            ProxySearcher proxySeacher = new ProxySearcher();
            proxySeacher.DoSearch("Tom", "冰红茶");
            Console.WriteLine("-------------------------------------");

            proxySeacher.DoSearch("杨过","冰红茶");

            Console.ReadKey();

        }
    }
}
