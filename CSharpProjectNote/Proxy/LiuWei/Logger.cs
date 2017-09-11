using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.LiuWei
{
    /// <summary>
    /// 日志记录类
    /// </summary>
    public class Logger
    {
        public void Log(string userId)
        {
            Console.WriteLine("更新数据库，用户"+userId+"查询次数加1");
        }
    }
}
