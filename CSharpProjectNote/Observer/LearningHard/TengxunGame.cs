using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.LearningHard
{
    /// <summary>
    /// 腾讯游戏订阅类(具体主题类)
    /// </summary>
    public class TengxunGame : Tengxun
    {
        public TengxunGame(string symbol, string info) :
            base(symbol, info)
        { }
    }
}