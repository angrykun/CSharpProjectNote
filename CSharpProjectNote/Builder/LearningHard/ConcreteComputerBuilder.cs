using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.LearningHard
{
    /// <summary>
    /// 具体建造者
    /// </summary>
    public class ConcreteComputerBuilder : ComputerBuilder
    {
        private Computer computer = new Computer();

        public override void BuildCPU()
        {
            computer.Add("CPU");
        }
        public override void BuildGPU()
        {
            computer.Add("GPU");
        }
        public override void BuildMainBoard()
        {
            computer.Add("主板");
        }
        public override Computer GetProduct()
        {
            return computer;
        }
    }
}
