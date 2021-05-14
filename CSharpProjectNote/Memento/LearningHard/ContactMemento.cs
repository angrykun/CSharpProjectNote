using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.LearningHard
{
    /// <summary>
    /// 备忘录
    /// PS：
    /// 存储原发器的内部状态，根据原发器来决定保存那些内部状态。
    /// 备忘录的设计一般可以参考原发器对象
    /// 备忘录除了供原发器和负责人类使用之外，不能被其他类直接使用。
    /// </summary>
    public class ContactMemento
    {
        public List<ContactPerson> contactPersonBack;
        public ContactMemento(List<ContactPerson> persons)
        {
            contactPersonBack = persons;
        }
    }
}
