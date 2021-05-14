using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.LearningHard
{
    /// <summary>
    /// 上下文类
    /// </summary>
    public class Account
    {
        public AbstractState State { get; set; }
        public string Owner { get; set; }

        public Account(string owner)
        {
            Owner = owner;
            State = new SilverState(0.00, this);
        }

        /// <summary>
        /// 余额
        /// </summary>
        public double Balance
        {
            get { return State.Balance; }
        }

        /// <summary>
        /// 存钱
        /// </summary>
        /// <param name="amount"></param>
        public void Deposit(double amount)
        {
            State.Deposit(amount);
            Console.WriteLine("存款金额为：{0:C}--", amount);
            Console.WriteLine("账户余额为=：{0:C}", Balance);
            Console.WriteLine("账户状态为:{0}", this.State.GetType().Name);
            Console.WriteLine();
        }

        /// <summary>
        /// 取钱
        /// </summary>
        /// <param name="amount"></param>

        public void Withdraw(double amount)
        {
            State.Withdraw(amount);
            Console.WriteLine("取款金额为：{0:C}--", amount);
            Console.WriteLine("账户余额为=：{0:C}", Balance);
            Console.WriteLine("账户状态为:{0}", State.GetType().Name);
            Console.WriteLine();
        }

        public void PayInterst()
        {
            State.PayInterest();
            Console.WriteLine("账户余额为=：{0:C}", Balance);
            Console.WriteLine("账户状态为:{0}", State.GetType().Name);
            Console.WriteLine();
        }
    }
}