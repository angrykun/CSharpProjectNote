using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.LearningHard
{
    /// <summary>
    ///  具体装饰者类(手机贴膜)
    /// </summary>
    public class Sticker : DecoratorPhone
    {
        public Sticker(Phone p) :
            base(p)
        { }

        public override void Print()
        {
            base.Print();

            //添加行为
            AddSticker();
        }
        /// <summary>
        /// 添加行为
        /// </summary>
        public void AddSticker()
        {
            Console.WriteLine("现在苹果手机有贴膜了");
        }
    }
}
