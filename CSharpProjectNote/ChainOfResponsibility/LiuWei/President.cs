﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.LiuWei
{
    public class President : Approver
    {
        public President(string name) :
            base(name)
        { }

        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 100000)
            {
                Console.WriteLine("总裁：{0}，审批采购单：{1}，金额：{2}元 ", Name, request.ProductName, request.Amount);
            }
            else if (Successor != null)
            {
                Console.WriteLine("{0}无权力批准采购：{1}，给上级{2}处理！", Name, request.ProductName, Successor.Name);
                Successor.ProcessRequest(request);
            }
        }
    }
}
