using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.LearningHard
{
    /// <summary>
    /// 抽象命令类
    /// </summary>
    public abstract class Command
    {
        protected Receiver receive;
        public Command(Receiver receive)
        {
            this.receive = receive;
        }
        public abstract void Action();
    }
}
