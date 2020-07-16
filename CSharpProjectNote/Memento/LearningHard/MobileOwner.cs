using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.LearningHard
{
    /// <summary>
    /// 发起人（Originator） 原发器
    /// </summary>
    public class MobileOwner
    {
        public List<ContactPerson> ContactPersons { get; set; }
        public MobileOwner(List<ContactPerson> persons)
        {
            ContactPersons = persons;
        }

        /// <summary>
        /// 创建备忘录，将当前需要保存的联系人列表导入备忘录中
        /// </summary>
        /// <returns></returns>
        public ContactMemento CreateMemento()
        {
            //这里应该传递深拷贝，new List 方式是浅拷贝
            //因为ContactPerson类中都是string类型，所以这里new List方式对ContactPerson对象进行了深拷贝
            //如果ContactPerson中包含非string的引用类型就会有问题，
            //所以这里应该序列化传递深拷贝
            return new ContactMemento(new List<ContactPerson>(this.ContactPersons));
        }
        /// <summary>
        /// 将备忘录中的数据备份导入到联系人列表中
        /// </summary>
        /// <param name="memento"></param>
        public void RestoreMemento(ContactMemento memento)
        {
            //这是错误的，因为这样传递的是引用
            //则删除一次可以恢复，但恢复之后再删除就无法恢复
            //应该传递ContactPerson的深拷贝，深拷贝可以使用序列化来完成
            ContactPersons = memento.contactPersonBack;
        }

        public void Show()
        {
            Console.WriteLine("联系人列表中有{0}个人，他们是:", ContactPersons.Count);
            foreach (var p in ContactPersons)
            {
                Console.WriteLine("姓名: {0} 号码为：{1}", p.Name, p.MoblieNum);
            }
        }
    }
}
