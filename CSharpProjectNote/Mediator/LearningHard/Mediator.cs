using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.LearningHard
{

    /// <summary>
    /// 具体中介者类
    /// </summary>
    public class Mediator : AbstractMediator
    {
        public Mediator(AbstractCardPartnerGrade a, AbstractCardPartnerGrade b) : base(a, b)
        { }

        public override void AWin(int count)
        {
            A.Moneny += count;
            B.Moneny -= count;
        }
        public override void BWin(int count)
        {
            A.Moneny -= count;
            B.Moneny += count;
        }
    }
}
