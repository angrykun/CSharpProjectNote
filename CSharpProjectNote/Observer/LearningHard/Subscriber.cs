using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.LearningHard
{
    /// <summary>
    /// 订阅类
    /// </summary>
    public class Subscriber : IObserver
    {
        public string Name { get; set; }

        public Subscriber(string name)
        {
            Name = name;
        }

        public void ReceiveAndPrintData(Tengxun txGame)
        {
            Console.WriteLine("Notified {0} of {1}'s" + " Info is: {2}", Name, txGame.Symbol, txGame.Info);
        }
    }
}