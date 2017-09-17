using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.LiuWei
{
    /// <summary>
    /// 具体观察者类
    ///
    /// 如果在某些复杂情况下，具体观察者类(ConcreteObserver)的Update方法在
    /// 执行时需要用到具体目标类ConcreteSubject中的状态，因此ConcreteObserver
    /// 与COncreteSubject之间有时候还存在关联关系。
    /// </summary>
    public class ConcreteObserver : Observer
    {
        public void Update()
        {
            Console.WriteLine("ConcreteObserver Update");
        }
    }
}