using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.LiuWei
{
    /// <summary>
    /// 真正主题类
    /// </summary>
    public class RealSearcher : Searcher
    {
        public string DoSearch(string userId, string key)
        {
            Console.WriteLine("用户:" + userId + ",使用关键字:" + key + "查询系统");
            return "查询到的内容";
        }
    }
}
