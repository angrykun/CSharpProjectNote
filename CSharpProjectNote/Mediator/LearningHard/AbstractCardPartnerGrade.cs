
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.LearningHard
{
    public abstract class AbstractCardPartnerGrade
    {
        public int Moneny { get; set; }
        public AbstractCardPartnerGrade()
        {
            Moneny = 0;
        }
        public abstract void ChangeCount(int count, AbstractMediator other);
    }
}
