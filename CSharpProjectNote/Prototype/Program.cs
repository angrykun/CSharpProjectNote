using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.Copy;
using Prototype.LearningHard;
using Prototype.LiuWei;

namespace Prototype
{
    #region Prototype 原型模式
    /**
     * 当创建一个类的实例的过程很昂贵或者很复杂，并且我们需要
     * 创建多个这样的类实例时，如果我们使用new操作符去创建实例，
     * 这会增加创建类的复杂度和耗费更多的内存空间。
     * 
     * 
     * 原型模式（Prototype Pattern）：使用原型实例指定创建对象的种类，
     * 并且通过克隆这些创建新的对象。原型模式是一种对象创建型模式。
     * 
     * 通过克隆方法创建的对象是全新的对象，它们在内存中拥有新的地址；
     * 通常对克隆产生的对象进行的修改不会对原型对象造成影响，每一个
     * 克隆对象都是相互独立的；
     */
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            //PrototypeMethodOne();
            PrototypeMethodThree();

            Console.Read();
        }
        static void Test()
        {
        }

        static void PrototypeMethodOne()
        {
            //孙悟空原型
            MonkeyKingPrototype prototypeMonkeyKing = new ConcreteProtype("MonkeyKing");

            //变一个
            MonkeyKingPrototype cloneKeyKing = prototypeMonkeyKing.Clone();
            Console.WriteLine("Clone1:" + cloneKeyKing.Id);
            //变一个
            MonkeyKingPrototype cloneKeyKing2 = prototypeMonkeyKing.Clone();
            cloneKeyKing2.Id = "Monkey";
            Console.WriteLine("Clone2:" + cloneKeyKing2.Id);
            Console.WriteLine("Clone1:" + cloneKeyKing.Id);

        }

        static void PrototypeMethodTwo()
        {
            //创建附件对象
            Attachment attachment = new Attachment("本周工作成果记录");
            //创建原型对象   
            WeekLog _previous = new WeekLog("张无忌", "第12周", "这周工作很忙，每天加班！", attachment);

            Console.WriteLine("***周报***");
            Console.WriteLine("周次：" + _previous.Date);
            Console.WriteLine("姓名：" + _previous.Name);
            Console.WriteLine("内容：" + _previous.Content);
            Console.WriteLine("--------------------");

            //调用克隆方法创建克隆对象
            WeekLog long_new = _previous.Clone();
            long_new.Date = "第13周";
            Console.WriteLine("***周报***");
            Console.WriteLine("周次：" + long_new.Date);
            Console.WriteLine("姓名：" + long_new.Name);
            Console.WriteLine("内容：" + long_new.Content);
            Console.WriteLine("--------------------");

            Console.WriteLine("周报是否相同？" + (long_new == _previous));
            Console.WriteLine("附件是否相同？" + (long_new.Attachment == _previous.Attachment));
        }
        static void PrototypeMethodThree()
        {
            //创建附件对象
            Attachment attachment = new Attachment("本周工作成果记录");
            //创建原型对象   
            WeekLog _previous = new WeekLog("张无忌", "第12周", "这周工作很忙，每天加班！", attachment);

            Console.WriteLine("***周报***");
            Console.WriteLine("周次：" + _previous.Date);
            Console.WriteLine("姓名：" + _previous.Name);
            Console.WriteLine("内容：" + _previous.Content);
            Console.WriteLine("--------------------");

            //调用克隆方法创建克隆对象
            WeekLog long_new = _previous.DeepClone();
            long_new.Date = "第13周";
            Console.WriteLine("***周报***");
            Console.WriteLine("周次：" + long_new.Date);
            Console.WriteLine("姓名：" + long_new.Name);
            Console.WriteLine("内容：" + long_new.Content);
            Console.WriteLine("--------------------");

            Console.WriteLine("周报是否相同？" + (long_new == _previous));
            Console.WriteLine("附件是否相同？" + (long_new.Attachment == _previous.Attachment));
        }


    }
}
