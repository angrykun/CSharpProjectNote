using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.LiuWei
{
    /// <summary>
    /// 采购请求
    /// </summary>
    public class PurchaseRequest
    {
        /// <summary>
        /// 金额
        /// </summary>
        public double Amount { get; set; }
        /// <summary>
        /// 产品名称
        /// </summary>
        public string ProductName { get; set; }

        public PurchaseRequest(double amount, string productName)
        {
            Amount = amount;
            ProductName = productName;
        }
    }
}
