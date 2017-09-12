using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Command.LearningHard
{
    /// <summary>
    ///命令接受者和处理者
    /// </summary>
    public class Receiver
    {
        public void Run()
        {
            Console.WriteLine("一二一，一二一......");
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.WriteLine("跑了" + i + "米");
            }
        }
    }
}
