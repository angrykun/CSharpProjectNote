using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.LearningHard
{
    /// <summary>
    /// 抽象牌友类
    /// </summary>
    public abstract class AbstractCardPartner
    {
        public int Moneny { get; set; }
        public AbstractCardPartner()
        {
            Moneny = 0;
        }
        public abstract void ChangeCount(int count,AbstractCardPartner other);
    }
}
