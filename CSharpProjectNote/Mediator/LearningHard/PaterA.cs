using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.LearningHard
{
    /// <summary>
    /// 具体牌友A
    /// </summary>
    public class PaterA : AbstractCardPartner
    {
        /// <summary>
        /// 重写父类中方法
        /// </summary>
        /// <param name="count"></param>
        /// <param name="other"></param>
        public override void ChangeCount(int count, AbstractCardPartner other)
        {
            Moneny += count;
            other.Moneny -= count;
        }
    }
}
