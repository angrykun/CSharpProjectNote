using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.LiuWei
{
    public abstract class Abstraction
    {
        /// <summary>
        /// 定义实现类接口抽象
        /// </summary>
        protected Implementor impl { get; set; }
        /// <summary>
        /// 生命抽象业务方法
        /// </summary>
        public abstract void Operation();
    }
}
