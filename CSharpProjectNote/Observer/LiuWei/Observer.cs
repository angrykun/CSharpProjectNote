using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.LiuWei
{
    /// <summary>
    /// 抽象观察者(一般定义为接口)
    /// </summary>
    public interface Observer
    {
        /// <summary>
        /// 声明响应方法
        /// </summary>
        void Update();
    }
}