using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.LearningHard
{
    public class ChangHong : TV
    {
        public override void On()
        {
            Console.WriteLine("长虹牌电视机开机......");
        }
        public override void Off()
        {
            Console.WriteLine("长虹牌电视机关机......");
        }
        public override void tuneChannel()
        {
            Console.WriteLine("长虹牌电视机切换频道......");
        }
    }
}
