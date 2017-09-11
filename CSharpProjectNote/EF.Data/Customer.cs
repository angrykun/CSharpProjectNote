using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF.Core;

namespace EF.Data
{
    public class Customer : BaseEntity
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 客户电子邮件
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 导航属性--Order 一个客户可以有很多订单
        /// </summary>
        public virtual ICollection<Order> Orders { get; set; }
    }
}
