using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChainOfResponsibility.LiuWei;

namespace ChainOfResponsibility
{
    /**
     * 职责链模式：避免让请求发送者和请求接受者耦合在一起，
     * 让多个对象都有机会接收请求， 将这些对象连成一条链，
     * 并且沿着这条链传递请求，直到有对象处理它为止。
     * **/
    class Program
    {
        static void Main(string[] args)
        {
            MethodOne();
        }
        static void MethodOne()
        {
            PurchaseRequest requestTelphone = new PurchaseRequest(4000.0, "Telphone");
            PurchaseRequest requestSoftware = new PurchaseRequest(10000.0, "Visual Studio");
            PurchaseRequest requestComputers = new PurchaseRequest(40000.0, "Computers");

            Approver manager = new Manager("张三");
            Approver Vp = new VicePresident("Tony");
            Approver Pre = new President("BossTom");

            //设置责任链
            manager.Successor = Vp;
            Vp.Successor = Pre;

            //处理请求
            manager.ProcessRequest(requestTelphone);
            Console.WriteLine("----------------------------");
            manager.ProcessRequest(requestSoftware);
            Console.WriteLine("----------------------------");
            manager.ProcessRequest(requestComputers);

            Console.ReadKey();

        }
    }
}
