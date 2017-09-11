using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.LearningHard
{
    /// <summary>
    /// 具体享元类
    /// </summary>
    public class ConcreteFlyweight : Flyweight
    {
        //内部状态
        private string intrinsicstate;

        //构造函数
        public ConcreteFlyweight(string innerState)
        {
            intrinsicstate = innerState;
        }

        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("具体实现类: intrinsicstate {0}, extrinsicstate {1}", intrinsicstate, extrinsicstate);
        }
    }
}
