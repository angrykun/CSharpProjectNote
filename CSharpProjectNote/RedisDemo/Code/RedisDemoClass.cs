using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Redis;
using ServiceStack.Caching;

namespace RedisDemo.Code
{
    public class RedisDemoClass
    {
        #region Redis 基础读取设置
        /// <summary>
        /// Redis 基础读取设置
        /// </summary>
        public void SetGetRedis()
        {
            RedisClientManagerConfig redisConfig = new RedisClientManagerConfig();
            redisConfig.AutoStart = true;
            redisConfig.MaxReadPoolSize = 60;
            redisConfig.MaxWritePoolSize = 60;

            PooledRedisClientManager prcm = new PooledRedisClientManager(new List<string> { "127.0.0.1" }, new List<string> { "127.0.0.1" }, redisConfig);

            //插入一条数据
            using (ICacheClient client = prcm.GetCacheClient())
            {
                client.Set<string>("name", "zhangsan");
            }

            //获取一条数据
            using (ICacheClient client = prcm.GetCacheClient())
            {
                Console.WriteLine(client.Get<string>("name"));
            }
            Console.ReadLine();
        }
        #endregion



        #region 使用Redis Helper读写
        /// <summary>
        /// 使用Redis Helper读写
        /// </summary>
        public void RedisHelperReadWrite()
        {

            Console.WriteLine("Redis 写入缓存:zhong");
            RedisCacheHelper.Add("zhong", "zhongzhongzhong", DateTime.Now.AddDays(1));

            Console.WriteLine("Redis获取缓存：zhong");
            string str3 = RedisCacheHelper.Get<string>("zhong");
            Console.WriteLine(str3);

            Console.WriteLine("Redis获取缓存：nihao");
            string str = RedisCacheHelper.Get<string>("nihao");
            Console.WriteLine(str);


            Console.WriteLine("Redis获取缓存：wei");
            string str1 = RedisCacheHelper.Get<string>("wei");
            Console.WriteLine(str1);

            Console.ReadKey();

        }
        #endregion
    }
}
