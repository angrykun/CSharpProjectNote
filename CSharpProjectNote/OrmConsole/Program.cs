using OrmConsole.Dal;
using OrmConsole.Model;
using System;

namespace OrmConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var post = SqlHelper.Find<Post>(2);
            Console.WriteLine(post.Author);
            Console.Read();
        }
    }
}
