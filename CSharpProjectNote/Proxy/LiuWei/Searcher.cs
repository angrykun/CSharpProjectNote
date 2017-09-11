using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.LiuWei
{
    /// <summary>
    /// 抽象主题类
    /// </summary>
    public interface Searcher
    {
        string DoSearch(string userId, string key);
    }
}
