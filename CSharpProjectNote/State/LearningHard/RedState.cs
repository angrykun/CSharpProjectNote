using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.LearningHard
{
    /// <summary>
    /// 具体状态类
    /// </summary>
    public class RedState : AbstractState
    {
        public RedState(AbstractState state)
        {
            Balance = state.Balance;
            Account = state.Account;
            Interest = 0.00;
            LowerLimit = -100.00;
            UpperLimit = 0.00;
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
            StateChangeCheck();
        }

        /// <summary>
        /// 取钱
        /// </summary>
        /// <param name="amount"></param>
        public override void Withdraw(double amount)
        {
            Console.WriteLine("没钱可以取了！");
        }

        public override void PayInterest()
        {
            throw new NotImplementedException();
        }

        private void StateChangeCheck()
        {
            if (Balance > UpperLimit)
            {
                Account.State = new SilverState(this);
            }
        }
    }
}