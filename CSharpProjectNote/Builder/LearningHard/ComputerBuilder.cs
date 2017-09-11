using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.LearningHard
{
    /// <summary>
    /// 抽象建造者
    /// </summary>
    public abstract class ComputerBuilder
    {                                                        
        /// <summary>
        /// 组装CPU
        /// </summary>
        public abstract void BuildCPU();
        /// <summary>
        /// 组装Board
        /// </summary>
        public abstract void BuildMainBoard();
        /// <summary>
        /// 组装GPU
        /// </summary>
        public abstract void BuildGPU();

        /// <summary>
        /// 获取组装电脑
        /// </summary>
        /// <returns></returns>
        public abstract Computer GetProduct();
    }
}
