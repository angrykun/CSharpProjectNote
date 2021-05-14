using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.LearningHard
{
    /// <summary>
    /// 中间传达者(单命令)
    /// </summary>
    public class Invoker
    {
        private Command command;

        public Invoker(Command command)
        {
            this.command = command;
        }
        public void ExecuteCommand()
        {
            Console.WriteLine("全体都有，跑步走......");
            command.Action();
        }
    }

    /// <summary>
    /// 中间传达者(多命令)
    /// </summary>
    public class InvokerQueue
    {
        private CommandQueue commandQueue;

        public InvokerQueue(CommandQueue commandQueue)
        {
            this.commandQueue = commandQueue;
        }
        public void Execute()
        {
            commandQueue.Execute();
        }
    }

}
