using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.LearningHard
{
    /// <summary>
    /// 具体装饰者类(手机挂件)
    /// </summary>
    public class Accessories : DecoratorPhone
    {
        public Accessories(Phone p) :
            base(p)
        { }

        public override void Print()
        {
            base.Print();

            //添加行为
            AddAccessories();
        }
        /// <summary>
        /// 添加行为
        /// </summary>
        public void AddAccessories()
        {
            Console.WriteLine("现在苹果手机有挂件了");
        }
    }
}
