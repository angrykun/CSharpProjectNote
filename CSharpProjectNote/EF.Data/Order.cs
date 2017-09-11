using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF.Core;

namespace EF.Data
{
    public class Order : BaseEntity
    {
        /// <summary>
        /// 数量
        /// </summary>
        public byte Quanatity { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 客户ID
        /// </summary>
        public int CustomerId { get; set; }
        /// <summary>
        /// 导航属性--Customer
        /// </summary>
        public virtual Customer Customer { get; set; }
    }
}
