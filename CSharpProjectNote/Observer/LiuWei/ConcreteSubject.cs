using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.LiuWei
{
    /// <summary>
    /// 具体主题类
    /// </summary>
    public class ConcreteSubject : Subject
    {
        public override void Notify()
        {
            foreach (Observer ob in observers)
            {
                ob.Update();
            }
        }
    }
}