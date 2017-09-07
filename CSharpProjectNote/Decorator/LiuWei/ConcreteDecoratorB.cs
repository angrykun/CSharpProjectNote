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
    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddBehavior();
        }
        private void AddBehavior()
        {
            Console.WriteLine("我是装饰者B的新增方法:AddBehavior");
        }
    }
}
