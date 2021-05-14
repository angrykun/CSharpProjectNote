using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.LiuWei
{
    /// <summary>
    /// 抽象观察者类
    /// </summary>
    public interface ObserverPlayer
    {
        string Name { get; set; }

        void Help();

        void BeAttacked(AllyControlCenter acc);
    }
}