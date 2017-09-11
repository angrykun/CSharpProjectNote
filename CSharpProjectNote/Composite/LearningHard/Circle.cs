using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.LearningHard
{
    /// <summary>
    /// 叶子节点(简单图形圆)
    /// </summary>
    public class Circle : Graphics
    {
        public Circle(string name) :
            base(name)
        { }

        public override void Draw()
        {
            Console.WriteLine("画"+Name);
        }
        public override void Add(Graphics g)
        {
            throw new Exception("不能像简单图形圆总添加简单图形");
        }
        public override void Remove(Graphics g)
        {
            throw new Exception("不能像简单图形圆总移除简单图形");
        }
    }
}
