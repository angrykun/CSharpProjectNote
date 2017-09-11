using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.LearningHard
{
    /// <summary>
    /// 真实主题
    /// </summary>
  public  class RealBuyPerson  :Person
    {
        public override void BuyProduct()
        {
            Console.WriteLine("帮我买一台IPhone和一台苹果电脑");
        }
    }
}
