using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.LiuWei
{
    public abstract class AbstractCommand
    {
        protected Adder adder;
        public int value;
        public AbstractCommand(Adder adder)
        {
            this.adder = adder;
        }
        /// <summary>
        /// 加命令
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public abstract int Execute(int value);
        /// <summary>
        /// 撤销命令
        /// </summary>
        /// <returns></returns>
        public abstract int Undo();
        public abstract AbstractCommand Clone();
    }
}
