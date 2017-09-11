using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BingTalk
{
    /// <summary>
    /// 具体产品类（复杂对象）
    /// </summary>
    public class Product
    {
        private IList<string> parts = new List<string>();
        /// <summary>
        /// 增加部件
        /// </summary>
        /// <param name="part"></param>
        public void Add(string part)
        {
            parts.Add(part);
        }

        /// <summary>
        /// 展示对象
        /// </summary>
        public void Show()
        {
            Console.WriteLine("产品 创建中....");
            foreach (var part in parts)
            {
                Console.WriteLine(part);
            }
            Console.WriteLine("产品 创建完毕....");
        }
    }
}
