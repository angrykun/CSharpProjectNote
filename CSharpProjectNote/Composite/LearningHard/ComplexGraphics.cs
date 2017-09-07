using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.LearningHard
{
    public class ComplexGraphics : Graphics
    {
        private IList<Graphics> complexGraphics = new List<Graphics>();
        public ComplexGraphics(string name) :
            base(name)
        { }

        /// <summary>
        /// 复杂图形画法
        /// </summary>
        public override void Draw()
        {
            foreach (var graphics in complexGraphics)
            {
                graphics.Draw();
            }
        }
        public override void Add(Graphics g)
        {
            complexGraphics.Add(g);
        }
        public override void Remove(Graphics g)
        {
            complexGraphics.Remove(g);
        }

    }
}
