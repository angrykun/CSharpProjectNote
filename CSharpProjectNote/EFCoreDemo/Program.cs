using System;
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
            using var context = new EFDbContext();

            var query = context.Orders.FirstOrDefault(x => x.Name == "笔记本电脑");
            Console.WriteLine($"query={JsonConvert.SerializeObject(query)}");
            Console.WriteLine("query--end");
            Console.Read();
            var order = new Order
            {
                Name = "笔记本电脑",
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

            Console.Read();
        }
    }
}
