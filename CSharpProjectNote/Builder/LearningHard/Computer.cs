using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.LearningHard
{
    /// <summary>
    /// 具体产品类
    /// </summary>
    public class Computer
    {
        //电脑部件集合
        private IList<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("组装电脑中...");
            foreach (var part in parts)
            {
                Console.WriteLine("组装" + part + "中...");
            }
            Console.WriteLine("电脑组装完毕...");
        }

    }
}
