using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memento.LearningHard;
using System.Threading;

namespace Memento
{
    /**
     *  备忘录模式：在不破坏封装的前提下，捕获一个对象的内部状态，
     *  并在该对象之外保存这个状态，这样以后就可以把对象恢复到原先状态。
     * **/
    class Program
    {
        static void Main(string[] args)
        {
            //MehtodOne();

            MethodTwo();

            Console.Read();
        }


        #region 创建单个还原点
        /// <summary>
        /// 创建单个还原点
        /// </summary>
        static void MehtodOne()
        {
            List<ContactPerson> persons = new List<ContactPerson> {
                new ContactPerson { Name="张三",MoblieNum="18620526698"},
                new ContactPerson { Name="李四",MoblieNum="13125858585"},
                new ContactPerson { Name="王五",MoblieNum="17525252639"},
                new ContactPerson { Name="赵钱",MoblieNum="15802565252"},
            };

            MobileOwner mobilerOwner = new MobileOwner(persons);
            mobilerOwner.Show();

            //创建备忘录并保存备忘录对象
            Caretaker caretaker = new Caretaker();
            caretaker.ContactM = mobilerOwner.CreateMemento();

            //更改发起人联系人列表
            Console.WriteLine("\n---移除最后一个联系人---");
            mobilerOwner.ContactPersons.RemoveAt(3);
            mobilerOwner.Show();

            //恢复到原始状态
            Console.WriteLine("\n---恢复联系人列表---");
            mobilerOwner.RestoreMemento(caretaker.ContactM);
            mobilerOwner.Show();

        }
        #endregion


        #region 创建多个还原点
        /// <summary>
        /// 创建多个还原点
        ///  </summary>
        static void MethodTwo()
        {
            List<ContactPerson> persons = new List<ContactPerson> {
                new ContactPerson { Name="张三",MoblieNum="18620526698"},
                new ContactPerson { Name="李四",MoblieNum="13125858585"},
                new ContactPerson { Name="王五",MoblieNum="17525252639"},
                new ContactPerson { Name="赵钱",MoblieNum="15802565252"},
            };

            MobileOwner mobilerOwner = new MobileOwner(persons);
            mobilerOwner.Show();

            //创建备忘录并保存备忘录对象
            CaretakerGrade caretaker = new CaretakerGrade();
            caretaker.ContactMementoDic.Add(DateTime.Now.ToString(), mobilerOwner.CreateMemento());

            //更改发起人联系人列表
            Console.WriteLine("\n---移除最后一个联系人---");
            mobilerOwner.ContactPersons.RemoveAt(3);
            mobilerOwner.Show();

            //创建第二个备份
            Thread.Sleep(1000);
            caretaker.ContactMementoDic.Add(DateTime.Now.ToString(), mobilerOwner.CreateMemento());

            //恢复到原始状态
            Console.WriteLine("\n---恢复联系人列表，请选择恢复日期---");
            var keyCollection = caretaker.ContactMementoDic.Keys;
            foreach (var key in keyCollection)
            {
                Console.WriteLine("key={0}", key);
            }

            while (true)
            {
                Console.WriteLine("请输入数字，按窗口关闭退出，数字不大于{0}", caretaker.ContactMementoDic.Count - 1);
                int index = -1;
                try
                {
                    index = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("输入的格式有误");
                }

                ContactMemento contactMementor = null;
                if (index < keyCollection.Count
                    && caretaker.ContactMementoDic.TryGetValue(keyCollection.ElementAt(index), out contactMementor))
                {
                    mobilerOwner.RestoreMemento(contactMementor);
                    mobilerOwner.Show();
                }
                else
                {
                    Console.WriteLine("输入索引大于集合长度！");
                }
            }
        }
        #endregion
    }
}
