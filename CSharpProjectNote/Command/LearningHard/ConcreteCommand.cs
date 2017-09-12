using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.LearningHard
{
    /// <summary>
    /// 具体命令
    /// </summary>
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receive)
            : base(receive)
        { }

        public override void Action()
        {
            receive.Run();
        }
    }
}
