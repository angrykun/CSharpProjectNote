using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.LearningHard
{
    /// <summary>
    /// 抽象中介者类
    /// </summary>
    public abstract class AbstractMediator
    {
        /// <summary>
        /// 包含对类的引用
        /// </summary>
        protected AbstractCardPartnerGrade A;
        protected AbstractCardPartnerGrade B;
        public AbstractMediator(AbstractCardPartnerGrade a, AbstractCardPartnerGrade b)
        {
            A = a;
            B = b;
        }
        public abstract void AWin(int count);
        public abstract void BWin(int count);
    }
}
