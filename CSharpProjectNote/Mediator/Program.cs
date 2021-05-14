using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator.LearningHard;

namespace Mediator
{

    /**
     *  中介者模式：定义一个中介对象，来封装一系列对象之间交互关系。
     *  中介者使对象之间不需要显示引用，从而降低耦合性，而且可以独立
     *  改变它们之间的交互行为。
     * 
     * **/
    class Program
    {
        static void Main(string[] args)
        {
            MethodOne();
            Console.WriteLine("--------------------------------------");
            MethodTwo();
            Console.ReadKey();
        }

        #region 未使用中介者模式
        /// <summary>
        /// 没有使用中介者设计模式，
        /// PaterA和PaterB 两者之间耦合度较高
        /// 通过引入第三个类，来解耦
        /// </summary>
        static void MethodOne()
        {
            AbstractCardPartner paterA = new PaterA();
            paterA.Moneny = 20;
            AbstractCardPartner paterB = new PaterB();
            paterB.Moneny = 20;

            //A赢10块钱
            paterA.ChangeCount(5, paterB);
            Console.WriteLine("A现在的钱:{0}", paterA.Moneny);
            Console.WriteLine("B现在的钱:{0}", paterB.Moneny);

            //A赢10块钱
            paterB.ChangeCount(10, paterA);
            Console.WriteLine("A现在的钱:{0}", paterA.Moneny);
            Console.WriteLine("B现在的钱:{0}", paterB.Moneny);

        }
        #endregion

        static void MethodTwo()
        {
            AbstractCardPartnerGrade A = new ParterAGrade();
            AbstractCardPartnerGrade B = new ParterBGrade();
            A.Moneny = 20;
            B.Moneny = 20;

            AbstractMediator mediator = new Mediator.LearningHard.Mediator(A, B);

            A.ChangeCount(5, mediator);
            Console.WriteLine("A现在的钱:{0}", A.Moneny);
            Console.WriteLine("B现在的钱:{0}", B.Moneny);

            B.ChangeCount(10, mediator);
            Console.WriteLine("A现在的钱:{0}", A.Moneny);
            Console.WriteLine("B现在的钱:{0}", B.Moneny);

        }
    }
}
