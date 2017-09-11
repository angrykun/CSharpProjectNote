using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.LiuWei
{
    /// <summary>
    /// 具体处理者(经理)
    /// </summary>
    public class Manager : Approver
    {
        public Manager(string name) : base(name)
        { }

        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 10000.0)
            {
                Console.WriteLine("经理：{0}，审批采购单：{1}，金额：{2}元 ", Name, request.ProductName, request.Amount);
            }
            else if (Successor != null)
            {
                Console.WriteLine("{0}无权力批准采购：{1}，给上级{2}处理！", Name, request.ProductName, Successor.Name);
                //如果有下家，则交由下家处理
                Successor.ProcessRequest(request);
            }
        }
    }
}
