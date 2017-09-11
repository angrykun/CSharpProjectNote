using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flyweight.LearningHard;
using Flyweight.LiuWei;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodTwo();
        }
        static void MethodOne()
        {
            //定义外部状态
            int externalstate = 10;

            //初始化享元工厂
            FlyweightFactory factory = new FlyweightFactory();

            Flyweight.LearningHard.Flyweight fa = factory.GetFlyweight("A");
            if (fa != null)
            {
                //把外部对象作为享元对象的方法调用参数
                fa.Operation(--externalstate);
            }

            Flyweight.LearningHard.Flyweight fb = factory.GetFlyweight("B");
            if (fb != null)
            {
                //把外部对象作为享元对象的方法调用参数
                fb.Operation(--externalstate);
            }

            Flyweight.LearningHard.Flyweight fc = factory.GetFlyweight("C");
            if (fc != null)
            {
                //把外部对象作为享元对象的方法调用参数
                fc.Operation(--externalstate);
            }

            Flyweight.LearningHard.Flyweight fd = factory.GetFlyweight("D");
            if (fd != null)
            {
                //把外部对象作为享元对象的方法调用参数
                fd.Operation(--externalstate);
            }

            Console.ReadKey();
        }


        static void MethodTwo()
        {
            IgoChessmanFactory factory = IgoChessmanFactory.GetInstance();

            IgoChessman black1 = factory.GetIgoChessman("b");

            IgoChessman black2 = factory.GetIgoChessman("b");

            IgoChessman black3 = factory.GetIgoChessman("b");

            Console.WriteLine("判断两颗黑子是否相同：" + (black1 == black2));

            IgoChessman white1 = factory.GetIgoChessman("w");

            IgoChessman white2 = factory.GetIgoChessman("w");

            IgoChessman white3 = factory.GetIgoChessman("w");

            Console.WriteLine("判断两颗百子是否相同：" + (white1 == white2));

            black1.Display();
            black2.Display();
            black3.Display();
            white1.Display();
            white2.Display();
            white3.Display();

            Console.ReadKey();
        }
    }
}
