using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.LearningHard
{
    /// <summary>
    /// 具体产品类(南昌鸭脖)
    /// </summary>
    public class nanchangYaBo : YaBo
    {
        public override void Print()
        {
            Console.WriteLine("南昌鸭脖");
        }
    }
}
