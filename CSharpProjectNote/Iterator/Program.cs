using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.LearningHard;
using Iterator.IteratorDemo;

namespace Iterator
{
    /**
     * 迭代器模式：提供一种方法来访问聚合对象，
     * 而不用暴露这个对象内部表示，其别名为游标（Cursor）
     * 
     * **/
    class Program
    {
        static void Main(string[] args)
        {

            MethodOne(); MethodTwo();
        }
        static void MethodOne()
        {
            Iterator.LearningHard.Iterator iterator;
            IListCollection list = new ConcreteList();
            iterator = list.GetIterator();
            while (iterator.MoveNext())
            {
                int i = (int)iterator.GetCurrent();
                Console.WriteLine(i.ToString());
                iterator.Next();
            }
            Console.ReadKey();
        }

        static void MethodTwo()
        {
            Friends friends = new Friends();
            foreach (Friend f in friends)
            {
                Console.WriteLine(f.Name);
            }
            Console.ReadKey();
        }
    }
}
