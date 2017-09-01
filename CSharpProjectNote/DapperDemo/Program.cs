using DapperDemo.Respository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo
{
    /// <summary>
    /// Dapper是一款轻量级ORM工具
    /// 优点：
    /// 1.轻量。只有一个文件(SqlMapper.cs)
    /// 2.速度快。Dapper的速度接近IDataReader，取列表的数据超过DataTable
    /// 3.支持多种数据库
    /// 4.可以映射一对一，一对多，多对多
    /// 5.性能高
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            var success = new DapperDemo().DeleteColumnCatAndColumn(new ED_Data { TableName = "123A2" });
            watch.Stop();
            Console.WriteLine($"结果： ，花费时间：{watch.ElapsedMilliseconds}");
            Console.Read();
        }
    }
}
