using System;
using System.Collections.Generic;
using System.Linq;
using EFCoreDemo.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace EFCoreDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddBlog();
            Console.Read();
        }

        static void QueryOrder()
        {
            using var context = new EFDbContext();
            var query = context.Orders.FirstOrDefault(x => x.Name == "笔记本电脑");
            Console.WriteLine($"query={JsonConvert.SerializeObject(query)}");
            Console.WriteLine("query--end");
            Console.Read();

        }

        static void AddOrder()
        {
            using var context = new EFDbContext();
            var order = new Order
            {
                Name = "笔记本电脑33",
                OrderStatus = OrderStatus.Created,
                Address = new Address
                {
                    Province = "上海市",
                    City = "上海市",
                    Street = "古北路666号2202"
                },
                Description = "这是一款很好的笔记本电脑",
                DetailedOrder = new DetailedOrder()
                {
                    Status = OrderStatus.Created,
                    ShippingAddress = "221 B Baker St, London",
                    BillingAddress = "11 Wall Street, New York"
                }
            };
            var orderEntity = context.Orders.Add(order).Entity;
            Console.WriteLine($"orderEntity:{ JsonConvert.SerializeObject(orderEntity)}");
            var result = context.SaveChanges();
            Console.WriteLine($"result:{result}");
        }

        static void QueryBlog()
        {

        }

        static void AddBlog()
        {
            var context = new EFDbContext();
            var blog = new Blog()
            {
                Url = "https://www.miscrosoft.com"
                //Posts = new List<Post>()
                //{
                //    new Post()
                //    {
                //        Content = "我是Post Content 11111",
                //        Title = "我是Post Title 111111"
                //    },
                //    new Post()
                //    {
                //        Content = "我是Post Content 22222",
                //        Title = "我是Post Title 22222"
                //    }, new Post()
                //    {
                //        Content = "我是Post Content 33333",
                //        Title = "我是Post Title 33333"
                //    }, new Post()
                //    {
                //        Content = "我是Post Content 44444",
                //        Title = "我是Post Title 44444"
                //    }, new Post()
                //    {
                //        Content = "我是Post Content 55555",
                //        Title = "我是Post Title 55555"
                //    },
                //}
            };

            //访问影子属性
            context.Entry(blog).Property("LastUpdated").CurrentValue = DateTime.Now;
            var blogs = context.Blogs.OrderBy(b => EF.Property<DateTime>(b, "LastUpdated"));


            var contextId = context.ContextId;



            context.Blogs.Add(blog);

            context.SaveChanges();

            var post = context.Posts.FirstOrDefault();
            Console.WriteLine("success");
            Console.Read();
        }
    }
}
