using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.LiuWei
{
    /// <summary>
    /// 抽象主题类
    /// </summary>
    public abstract class AllyControlCenter
    {
        public string AllyName { get; set; }
        protected List<ObserverPlayer> players;

        public AllyControlCenter(string allyName)
        {
            players = new List<ObserverPlayer>();
            AllyName = allyName;
        }

        public void Join(ObserverPlayer player)
        {
            players.Add(player);
            Console.WriteLine(player.Name + "加入" + AllyName + "战队");
        }

        public void Quit(ObserverPlayer player)
        {
            players.Remove(player);
            Console.WriteLine(player.Name + "退出入" + AllyName + "战队");
        }

        public abstract void Notify(string name);
    }
}