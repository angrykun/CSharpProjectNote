using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.LearningHard
{
    /// <summary>
    /// 抽象主题类  (定义代理和真实主题的公共方法)
    /// </summary>
   public abstract class Person
    {
        /// <summary>
        /// 公共方法
        /// </summary>
        public abstract void BuyProduct();
    }
}
