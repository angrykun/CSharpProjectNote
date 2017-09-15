using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.LearningHard
{
    /// <summary>
    /// 具体牌友A（使用中介者设计模式）
    /// </summary>
    public class ParterAGrade : AbstractCardPartnerGrade
    {
        public override void ChangeCount(int count, AbstractMediator other)
        {
            other.AWin(count);
        }
    }
}
