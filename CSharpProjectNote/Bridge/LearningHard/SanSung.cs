using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.LearningHard
{
    /// <summary>
    /// 三星牌电视机
    /// </summary>
    public class SanSung : TV
    {
        public override void On()
        {
            Console.WriteLine("三星牌电视机开机......");
        }
        public override void Off()
        {
            Console.WriteLine("三星牌电视机关机......");
        }
        public override void tuneChannel()
        {
            Console.WriteLine("三星牌电视机切换频道......");
        }
    }
}
