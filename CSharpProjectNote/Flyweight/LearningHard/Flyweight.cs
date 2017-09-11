using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.LearningHard
{
    /// <summary>
    /// 抽象享元类
    /// </summary>
    public abstract class Flyweight
    {
        /// <summary>
        /// 方法
        /// </summary>
        /// <param name="extrinsicstate"></param>
        public abstract void Operation(int extrinsicstate);
    }
}
