using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BingTalk
{
    /// <summary>
    /// 具体建造者
    /// </summary>
    public class ConcreteBuilder : Builder
    {
        private Product product = new Product();
        /// <summary>
        /// 具体建造者 建造部件A
        /// </summary>
        public override void BuildPartA()
        {
            product.Add("部件A");
        }

        /// <summary>
        /// 具体建造者 建造部件B
        /// </summary>
        public override void BuildPartB()
        {
            product.Add("部件B");
        }

        /// <summary>
        /// 获取对象
        /// </summary>
        /// <returns></returns>
        public override Product GetProduct()
        {
            return product;
        }
    }
}
