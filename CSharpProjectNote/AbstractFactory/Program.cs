using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.LearningHard;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodOne();
        }
        static void MethodOne()
        {
            //上海工厂制作上海鸭脖鸭架
            AbstractFactoryDemo shanghaiFactory = new shanghaiFactory();
            YaBo shanghaiYabo = shanghaiFactory.CreateYaBo();
            shanghaiYabo.Print();
            YaJia shanghaiYaJia = shanghaiFactory.CreateYaJia();
            shanghaiYaJia.Print();

            Console.WriteLine("-----------------");

            //南昌工厂制作难上鸭脖鸭架
            AbstractFactoryDemo nanchangFactory = new nanchangFactory();
            YaBo nanchangYabo = nanchangFactory.CreateYaBo();
            nanchangYabo.Print();
            YaJia nanchangYaJia = nanchangFactory.CreateYaJia();
            nanchangYaJia.Print();

            Console.ReadKey();

            /**
             * 如果要新开一家南京分店，则只要添加3个类，
             * 负责创建南京口味的鸭脖鸭架工厂类，
             * 南京口味鸭脖类，南京口味鸭架类。
             * 
             * 抽象工厂对于系列产品的变化支持“开闭原则”(对修改封闭，对扩展开放)
             * 扩展起来很简单，但是抽象工厂对于添加新产品情况就不支持“开闭原则”，
             * 比如以上实例中，新增一种“鸭头”，则需要对工厂进行修改，违反了“开闭原则”。
             * 这也是抽象工厂的缺点。
             * 
             * 抽象工厂模式很难支持新种类产品的变化，因为抽象工厂接口中已经确定了可以被创建
             * 的产品集合，如果需要添加新产品，必须要修改抽象工厂中接口，这样就设计到抽象工厂类
             * 以及所有子类的改变，这也违背了“开闭原则”  。
             * */

        }
    }
}
