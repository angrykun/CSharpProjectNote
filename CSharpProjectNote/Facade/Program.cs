using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.LearningHard;

namespace Facade
{
    /**
     * 外观模式：提供了一个统一的接口，用来访问子系统中的一群接口。
     * 外观模式定义了一个高层接口，让子系统更容易使用，使用外观模式时
     * 我们创建一个统一的类，用来包装子系统中一个或多个复杂的类，
     * 客户端可以直接通过外观类来调用内部系统中方法，从而避免
     * 客户端与子系统之间的紧耦合。
     * 
     * 
     * 外观模式核心：由外观类去保存各个子系统的引用，实现由一个统一的
     * 外观类去包装多个子系统类，客户端只需要引用这个外观类，就可以
     * 调用各个子系统的方法。
     * 
     * 
     * 适配器模式是将一个对象包装起来以改变其接口，而外观是将一群对象
     * 包装起来，以简化调用。
     * **/
    class Program
    {
        static void Main(string[] args)
        {
            MethodOne();
        }
        static void MethodOne()
        {
            RegistrationFacade facade = new RegistrationFacade();
            facade.RegisterCourse("英语","Tom");

            Console.ReadKey();
        }
    }
}
