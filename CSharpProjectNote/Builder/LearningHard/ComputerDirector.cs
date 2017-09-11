using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.LearningHard
{
    /// <summary>
    /// 指挥者类
    /// </summary>
    public class ComputerDirector
    {
        public void Construct(ComputerBuilder builder)
        {
            builder.BuildCPU();
            builder.BuildGPU();
            builder.BuildMainBoard();
        }
    }
}
