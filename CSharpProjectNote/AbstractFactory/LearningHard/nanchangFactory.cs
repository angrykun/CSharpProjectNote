using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.LearningHard
{
    /// <summary>
    /// 具体工厂类(生产南昌鸭脖，鸭架)
    /// </summary>
    public class nanchangFactory : AbstractFactoryDemo
    {
        /// <summary>
        /// 生产鸭脖
        /// </summary>
        /// <returns></returns>
        public override YaBo CreateYaBo()
        {
            Console.WriteLine("南昌工厂生产南昌鸭脖");
            return new nanchangYaBo();
        }

        /// <summary>
        /// 生产鸭架
        /// </summary>
        /// <returns></returns>
        public override YaJia CreateYaJia()
        {
            Console.WriteLine("南昌工厂生产南昌鸭架");
            return new nanchangYaJia();
        }

    }
}
