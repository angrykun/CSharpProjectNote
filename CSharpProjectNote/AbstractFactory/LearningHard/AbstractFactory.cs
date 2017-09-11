using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.LearningHard
{
    /// <summary>
    /// 抽象工厂
    /// </summary>
    public abstract class AbstractFactoryDemo
    {
        /// <summary>
        /// 生产鸭脖
        /// </summary>
        /// <returns></returns>
        public abstract YaBo CreateYaBo();
        /// <summary>
        /// 生产鸭架
        /// </summary>
        /// <returns></returns>
        public abstract YaJia CreateYaJia();
    }
}
