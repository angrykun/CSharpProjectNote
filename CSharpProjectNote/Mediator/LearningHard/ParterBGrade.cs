using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.LearningHard
{
    public class ParterBGrade : AbstractCardPartnerGrade
    {
        public override void ChangeCount(int count, AbstractMediator other)
        {
            other.BWin(count);
        }
    }
}
