using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.LearningHard
{
    /// <summary>
    /// 叶子节点(线)
    /// </summary>
    public class Line : Graphics
    {
        public Line(string name) :
            base(name)
        { }
        public override void Draw()
        {
            Console.WriteLine("画" + Name);
        }
        /// <summary>
        /// 因为简单图形是组合成复杂图形的基本，
        /// 所以对简单图形添加移除简单图形是没有意义的
        /// 所以抛出异常，让客户端捕获异常并处理
        /// </summary>
        /// <param name="g"></param>
        public override void Add(Graphics g)
        {
            throw new Exception("不能像简单图形Line添加其他图形");
        }

        public override void Remove(Graphics g)
        {
            throw new Exception("不能像简单图形Line移除其他图形");
        }
    }
}
