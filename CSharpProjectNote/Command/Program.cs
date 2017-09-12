
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.LearningHard;
using Command.LiuWei;

namespace Command
{
    /**
     *  命令模式：将一个请求封装为一个对象，从而可用不同的
     *  请求对客户进行参数化，对请求排队或记录请求日志，以及
     *  支持可撤销的操作。
     * **/
    class Program
    {
        static void Main(string[] args)
        {
            //MethodOne();
            MethodTwo();
        }
        /// <summary>
        /// 单次撤销
        /// </summary>
        static void MethodOne()
        {
            //初始化接受者
            Receiver reciver = new Receiver();
            //初始化命令
            Command.LearningHard.Command command = new ConcreteCommand(reciver);
            //初始化中间者
            Invoker invoker = new Invoker(command);
            //调用
            invoker.ExecuteCommand();

            Console.ReadKey();
        }

        /// <summary>
        /// 实现多次撤销及重做(保存操作命令即可)
        /// </summary>
        static void MethodTwo()
        {
            Adder adder = new Adder();
            AbstractCommand command = new AddCommand(adder);
            CalculatorForm form = new CalculatorForm(command);
            form.Execute(10);//10
            form.Execute(5); //15
            form.Execute(10);//25
            form.Undo();//15
            form.Undo();//10
            form.Execute(3);//13
            form.Execute(6);//19
            form.Undo(); //13
            form.Undo();//10
            form.Undo();//0
            form.Redo();//10
            form.Redo();//13
            Console.ReadKey();
        }
    }
}
