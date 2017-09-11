using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.LiuWei
{
    /// <summary>
    /// 抽象处理者(审批类)
    /// </summary>
    public abstract class Approver
    {
        //对下家的引用
        public Approver Successor { get; set; }
        /// <summary>
        /// 审批者姓名
        /// </summary>
        public string Name { get; set; }

        public Approver(string name)
        {
            Name = name;
        }

        /// <summary>
        /// 抽象处理请求方法
        /// </summary>
        public abstract void ProcessRequest(PurchaseRequest request);
    }
}
