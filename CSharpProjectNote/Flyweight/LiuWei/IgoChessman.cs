using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.LiuWei
{
    /// <summary>
    /// 抽象享元类
    /// </summary>
    public abstract class IgoChessman
    {
        public abstract string GetColor();
        public void Display()
        {
            Console.WriteLine("棋子颜色：" + GetColor());
        }
    }
}
