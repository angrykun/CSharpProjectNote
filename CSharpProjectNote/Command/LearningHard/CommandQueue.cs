using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.LearningHard
{
    /// <summary>
    /// 命令队列
    /// </summary>
    public class CommandQueue
    {
        private IList<Command> list = new List<Command>();

        public void AddCommand(Command command)
        {
            list.Add(command);
        }
        public void RemoveCommand(Command command)
        {
            list.Remove(command);
        }
        public void Execute()
        {
            list.ToList().ForEach(item => item.Action());
        }
    }
}
