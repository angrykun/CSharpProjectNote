using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace MEF
{
    #region MEF(Managed Extensibility Framework)
    /**
     * ①MSDN上面解释：MEF(Managed Extensibility Framework)是一个用于创建可扩展的轻型应用程序库。
     *  应用程序开发人员可以利用该库发现并使用扩展，而无需进行配置。扩展开发人员还可以利用该库
     *  轻松封装代码，避免生成脆弱的硬依赖项。通过MEF，不仅可以在应用程序内重用扩展，还可以在应用
     *  程序之间重用扩展。
     *  PS：也有把MEF解释为“依赖注入”的一种方式。
     * ②MEF使用
     *     (1)MEF基础导入导出的使用分为三步：宿主MEF并组合部件，标记对象的导出，对象的导入使用。 
     * **/


    #endregion

    class Program
    {
        /// <summary>
        /// [Import]特性，它的底层就是给我们初始化了一个对象。
        /// [Import("chinese_hello")] 等价于Person person=new Chinese();
        /// 使用特性的好处：可以减少dll之间的引用。
        /// </summary>
        [Import("chinese_hello")]
        public Person person { get; set; }
        static void Main(string[] args)
        {
            var oProgram = new Program();
            oProgram.MyComposePart();
            var strRes = oProgram.person.SayHello("李磊");
            Console.WriteLine(strRes);

            Console.Read();
        }
        //宿主MEF组合部件
        void MyComposePart()
        {
            var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            var container = new CompositionContainer(catalog);
            //将部件(part)和宿主程序添加到组合容器
            container.ComposeParts(this);
        }
    }

    public interface Person
    {
        string SayHello(string name);
    }

    //声明对象可以导出
    [Export("chinese_hello", typeof(Person))]
    public class Chinese : Person
    {
        public string SayHello(string name)
        {
            return "你好：" + name;
        }
    }
    [Export("american_hello", typeof(Person))]
    public class American : Person
    {
        public string SayHello(string name)
        {
            return "Hello:" + name;
        }
    }

}
