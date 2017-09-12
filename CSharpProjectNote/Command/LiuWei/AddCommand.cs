using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.LiuWei
{
    public class AddCommand : AbstractCommand
    {
        public AddCommand(Adder adder) : base(adder)
        { }
        public override int Execute(int value)
        {
            this.value = value;
            return adder.Add(value);
        }
        /// <summary>
        /// 撤销操作命令
        /// </summary>
        /// <returns></returns>
        public override int Undo()
        {
            return adder.Add(-value);
        }
        public override AbstractCommand Clone()
        {
            return MemberwiseClone() as AbstractCommand;
        }
    }
}
