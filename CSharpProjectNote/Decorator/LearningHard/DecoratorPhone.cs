using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.LearningHard
{
    /// <summary>
    /// 抽象观察者
    /// </summary>
    public abstract class DecoratorPhone : Phone
    {
        /// <summary>
        /// 对抽象构件的引用
        /// </summary>
        private Phone phone;

        public DecoratorPhone(Phone p)
        {
            phone = p;
        }
        public override void Print()
        {
            if (phone != null)
            {
                phone.Print();
            }
        }
    }
}
