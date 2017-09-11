using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.LearningHard
{
    public class NotifyStudent
    {
        public bool Notify(string studentname)
        {
            Console.WriteLine("正在向{0}发送通知", studentname);
            return true;
        }
    }
}
