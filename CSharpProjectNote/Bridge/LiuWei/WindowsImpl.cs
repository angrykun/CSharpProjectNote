using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.LiuWei
{
    public class WindowsImpl : ImageImpl
    {
        public void DoPaint(Matrix m)
        {
            //调用windows系统的绘制函数绘制像素矩阵
            Console.WriteLine("在windows操作系统中显示图像");
        }
    }
}
