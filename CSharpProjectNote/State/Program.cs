using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using State.LearningHard;

namespace State
{
    /**
     *状态者模式：允许一个对象在其内部状态改变时自动改变其行为，对象开起来就像是改变了它的类。
     * **/

    internal class Program
    {
        private static void Main(string[] args)
        {
            MethodOne();
        }

        private static void MethodOne()
        {
            //新开一个账户
            Account account = new Account("Tom");

            //存钱
            account.Deposit(1000.0);
            account.Deposit(200.0);
            account.Deposit(600.0);

            //付利息
            account.PayInterst();

            //取钱
            account.Withdraw(2000.00);
            account.Withdraw(500);

            Console.ReadKey();
        }
    }
}