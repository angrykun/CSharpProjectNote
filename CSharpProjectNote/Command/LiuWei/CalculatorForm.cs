using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.LiuWei
{
    public class CalculatorForm
    {
        private AbstractCommand command;

        //undo 撤销列表 
        private List<AbstractCommand> undoCommand_list;
        //redo 重做列表 
        private List<AbstractCommand> redoCommand_list;

        public CalculatorForm(AbstractCommand command)
        {
            undoCommand_list = new List<AbstractCommand>();
            redoCommand_list = new List<AbstractCommand>();
            this.command = command;
        }
        public void Execute(int value)
        {
            command.value = value;
            undoCommand_list.Add(command.Clone());
            int result = command.Execute(value);
            Console.WriteLine("执行计算的运算结果：" + result);
        }
        /// <summary>
        /// 撤销
        /// </summary>
        public void Undo()
        {
            var count = undoCommand_list.Count;
            if (count > 0)
            {
                var command = undoCommand_list[--count];
                int result = command.Undo();
                redoCommand_list.Add(command);
                undoCommand_list.Remove(command);
                Console.WriteLine("执行撤销的运算结果：" + result);
            }
        }
        /// <summary>
        /// 重做
        /// </summary>
        public void Redo()
        {
            var count = redoCommand_list.Count;
            if (count > 0)
            {
                var command = redoCommand_list[--count];
                int result = command.Execute(command.value);
                redoCommand_list.Remove(command);
                Console.WriteLine("执行重做的运算结果：" + result);
            }

        }
    }
}
