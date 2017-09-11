using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.LearningHard
{
    /// <summary>
    /// 抽象构件类(图形类)
    /// </summary>
    public abstract class Graphics
    {
        public string Name { get; set; }
        public Graphics(string name)
        {
            Name = name;
        }
        /// <summary>
        /// 画图形 
        /// </summary>
        public abstract void Draw();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="g"></param>
        public abstract void Add(Graphics g);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="g"></param>
        public abstract void Remove(Graphics g);

    }
}
