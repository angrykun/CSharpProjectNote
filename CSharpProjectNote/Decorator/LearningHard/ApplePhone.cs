using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.LearningHard
{
    /// <summary>
    /// 具体构件类
    /// </summary>
   public class ApplePhone   :Phone
    {
        public override void Print()
        {
            Console.WriteLine("开始执行具体对象--苹果手机");
        }
    }
}
