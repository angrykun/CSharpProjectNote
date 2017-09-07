using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BingTalk
{
    /// <summary>
    /// 抽象建造者
    /// </summary>
    public abstract class Builder
    {
        /// <summary>
        /// 创建部件A
        /// </summary>
        public abstract void BuildPartA();
        /// <summary>
        /// 创建部件B
        /// </summary>
        public abstract void BuildPartB();
        /// <summary>
        /// 获取复杂对象
        /// </summary>
        /// <returns></returns>
        public abstract Product GetProduct();
    }
}
