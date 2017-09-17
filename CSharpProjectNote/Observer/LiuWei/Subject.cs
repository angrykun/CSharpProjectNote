using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.LiuWei
{
    /// <summary>
    /// 抽象主题类
    /// </summary>
    public abstract class Subject
    {
        protected List<Observer> observers = new List<Observer>();

        /// <summary>
        /// 注册方法，用于向观察者集合添加一个观察者
        /// </summary>
        /// <param name="observer"></param>
        public void Attatch(Observer observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// 删除方法，用于在观察者集合中删除一个观察者
        /// </summary>
        /// <param name="observer"></param>
        public void Deattach(Observer observer)
        {
            observers.Remove(observer);
        }

        /// <summary>
        /// 声明抽象通知方法
        /// </summary>
        public abstract void Notify();
    }
}