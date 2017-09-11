using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.LiuWei;
using Decorator.LearningHard;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodOne();
            MethodTwo();
        }
        static void MethodOne()
        {
            //创建具体构件
            Component component = new ConcreteComponent();

            //创建具体装饰者
            Decorator.LiuWei.Decorator decorator = new ConcreteDecoratorA();
            decorator.SetComponent(component);

            //创建具体装饰者
            Decorator.LiuWei.Decorator decorator2 = new ConcreteDecoratorB();
            decorator2.SetComponent(component);
            Console.WriteLine();

            decorator.Operation();
            Console.WriteLine("-------------------------------");
            decorator2.Operation();
            Console.Read();

        }

        static void MethodTwo()
        {
            //买了苹果手机
            Phone phone = new ApplePhone();

            //给手机贴膜
            DecoratorPhone sticker = new Sticker(phone);
            sticker.Print();

            //给手机增加挂件
            DecoratorPhone accessories = new Accessories(phone);
            accessories.Print();

            Console.ReadKey();
        }
    }
}
