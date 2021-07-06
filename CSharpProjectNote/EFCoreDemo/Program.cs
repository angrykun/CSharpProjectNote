using System;
using Microsoft.Extensions.DependencyInjection;

namespace EFCoreDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var service = new ServiceCollection();
            service.AddDbContext<EFDbContext>(); 
        }
    }
}
