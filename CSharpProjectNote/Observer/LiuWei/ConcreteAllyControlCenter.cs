using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.LiuWei
{
    public class ConcreteAllyControlCenter : AllyControlCenter
    {
        public ConcreteAllyControlCenter(string allyName) : base(allyName)
        {
            Console.WriteLine(allyName + "战队组建成功！");
            Console.WriteLine("----------------------------");
        }

        public override void Notify(string name)
        {
            Console.WriteLine(AllyName + "战队紧急通知，盟友" + name + "遭受敌人攻击！");
            foreach (ObserverPlayer player in players)
            {
                if (player != null)
                {
                    player.Help();
                }
            }
        }
    }
}