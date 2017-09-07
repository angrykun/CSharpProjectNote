using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BingTalk
{
    /// <summary>
    /// 指挥者
    /// </summary>
    public class Director
    {
        public void Construct(Builder builder)
        {
            //先创建部件A
            builder.BuildPartA();
            //创建部件B
            builder.BuildPartB();
        }
    }
}
