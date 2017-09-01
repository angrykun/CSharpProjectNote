using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.LearningHard;

namespace Bridge
{
    #region LiuWei
    /**
    * 桥接模式：将抽象部分与它的实现部分分离，使它们都可以独立变化。
    * 它是一种对象结构型模式，又称为柄体模式(Handle and Body)或
    * 接口(Interface)模式
    *  
    **/
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            //BridgeMethodOne();
            Console.Read();
        }
        static void BridgeMethodOne()
        {
            //创建一个遥控器
            RemoteControl remoteControl = new ConcreteRemote();
            //长虹电视机
            remoteControl.Implementor = new ChangHong();
            remoteControl.On();
            remoteControl.SetChannel();
            remoteControl.Off();
            Console.WriteLine();

            //三星电视机
            remoteControl.Implementor = new SanSung();
            remoteControl.On();
            remoteControl.SetChannel();
            remoteControl.Off();
        }
    }
}
