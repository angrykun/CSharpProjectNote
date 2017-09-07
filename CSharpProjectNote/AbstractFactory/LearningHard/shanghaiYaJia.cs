using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.LearningHard
{
    /// <summary>
    /// 具体产品类(上海鸭架)
    /// </summary>
    public class shanghaiYaJia : YaJia
    {
        public override void Print()
        {
            Console.WriteLine("上海鸭架");
        }
    }
}
