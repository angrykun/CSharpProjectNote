using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.LiuWei
{
    /// <summary>
    /// 具体观察者类
    /// </summary>
    public class Player : ObserverPlayer
    {
        public string Name { get; set; }

        /// <summary>
        /// 支援盟友方法的实现
        /// </summary>
        public void Help()
        {
            Console.WriteLine("坚持住，" + Name + "来救你！");
        }

        public void BeAttacked(AllyControlCenter acc)
        {
            Console.WriteLine(Name + "被攻击！");
            acc.Notify(Name);
        }
    }
}