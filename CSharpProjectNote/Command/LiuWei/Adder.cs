using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.LiuWei
{
    /// <summary>
    /// 接收者
    /// </summary>
    public class Adder
    {
        int num = 0;
        public int Add(int value)
        {
            return num = num + value;
        }

    }
}
