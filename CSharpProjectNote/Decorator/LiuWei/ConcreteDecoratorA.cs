using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.LiuWei
{
    /// <summary>
    /// 具体装饰者类
    /// </summary>
    public class ConcreteDecoratorA : Decorator
    {
        private string AddState { get; set; }
        public override void Operation()
        {
            base.Operation();
            AddState = "new state";
            Console.WriteLine("具体装饰对象A的操作" + AddState);
        }
    }
}
