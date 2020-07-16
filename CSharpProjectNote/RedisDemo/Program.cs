using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Redis;
using ServiceStack.Caching;
using RedisDemo.Code;

namespace RedisDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string aa = "9658";
            string bb = "256";
            var a = aa.ToString().PadLeft(4, '0');
            var b = bb.ToString().PadLeft(4, '0');
            var b2 = bb.ToString().PadLeft(3, '0');
            //MethodOne();
            MethodTwo();

        }
        static void MethodOne()
        {
            new RedisDemoClass().SetGetRedis();
        }
        static void MethodTwo()
        {
            new RedisDemoClass().RedisHelperReadWrite();
        }
    }
}
