using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.BingTalk;
using Builder.LearningHard;
using Builder.LiuWei;

namespace Builder
{

    /**
     * 建造者模式核心在于如何一步一步构建一个包含多个组成部件的完整对象，
     * 使用相同构建过程构建不同的产品。
     * 如果软件开发中，需要创建复杂对象，并希望系统具备很好的灵活性和可扩展型
     * 可以考虑使用建造者模式
     **/
    class Program
    {
        static void Main(string[] args)
        {
            MethodOne();
            MethodTwo();
            MethodThree();
        }
        static void MethodOne()
        {
            Director director = new Director();
            Builder.BingTalk.Builder builder = new ConcreteBuilder();
            director.Construct(builder);
            Product product1 = builder.GetProduct();
            product1.Show();

            Console.ReadKey();
        }

        static void MethodTwo()
        {
            //创建建造者
            ComputerBuilder builder = new ConcreteComputerBuilder();
            //创建指挥者
            ComputerDirector director = new ComputerDirector();
            director.Construct(builder);

            //创建具体产品
            Computer computer = builder.GetProduct();
            computer.Show();

            Console.ReadKey();
        }

        static void MethodThree()
        {
            VideoBuilder builder = new FullPattern();

            VideoDirector director = new VideoDirector();
            director.Construct(builder);

            //完整模式
            VideoSoftware product = builder.GetVideoSoftwarePattern();
            product.Show();

            //精简模式
            VideoBuilder builder2 = new SimplePattern();
            director.Construct(builder2);
            VideoSoftware product2 = builder2.GetVideoSoftwarePattern();
            product2.Show();

            Console.Read();
        }
    }
}
