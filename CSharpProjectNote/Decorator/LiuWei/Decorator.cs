using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.LiuWei
{
    /// <summary>
    /// 装饰者抽象类
    /// </summary>
    public abstract class Decorator : Component
    {
        private Component Component { get; set; }
        public override void Operation()
        {
            if (Component != null)
            {
                Component.Operation();
            }
        }
        public void SetComponent(Component component)
        {
            Component = component;
        }
        public Component GetComponent()
        {
            return Component;
        }
    }
}
