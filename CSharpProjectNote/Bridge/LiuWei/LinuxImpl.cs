using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.LiuWei
{
    /// <summary>
    /// Linux 操作系统实现类：具体实现类
    /// </summary>
    public class LinuxImpl : ImageImpl
    {
        public void DoPaint(Matrix m)
        {

            Console.WriteLine("在Linux系统中显示图像");
        }
    }
}
