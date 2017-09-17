using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.LearningHard
{
    /// <summary>
    /// 抽象主题 类
    /// </summary>
    public abstract class Tengxun
    {
        //保存订阅者列表
        private List<IObserver> observers = new List<IObserver>();

        public string Symbol { get; set; }
        public string Info { get; set; }

        public Tengxun(string symbol, string info)
        {
            Symbol = symbol;
            Info = info;
        }

        #region 新增对订阅号列表的维护操作

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            observers.Remove(observer);
        }

        #endregion 新增对订阅号列表的维护操作

        public void Update()
        {
            foreach (IObserver observer in observers)
            {
                if (observer != null)
                {
                    observer.ReceiveAndPrintData(this);
                }
            }
        }
    }
}