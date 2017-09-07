using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.LearningHard
{
    /// <summary>
    /// 具体工厂类（生产上海鸭脖鸭架）
    /// </summary>
    public class shanghaiFactory : AbstractFactoryDemo
    {  /// <summary>
       /// 生产鸭脖
       /// </summary>
       /// <returns></returns>
        public override YaBo CreateYaBo()
        {
            Console.WriteLine("上海工厂生产上海鸭脖");
            return new shanghaiYaBo();
        }

        /// <summary>
        /// 生产鸭架
        /// </summary>
        /// <returns></returns>
        public override YaJia CreateYaJia()
        {
            Console.WriteLine("上海工厂生产上海鸭架");
            return new shanghaiYaJia();
        }
    }
}
