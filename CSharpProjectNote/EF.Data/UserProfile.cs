﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF.Core;

namespace EF.Data
{
    /// <summary>
    /// 用户详情实体
    /// </summary>
    public class UserProfile : BaseEntity
    {
        /// <summary>
        /// 姓
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// 名
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 导航属性--User
        /// </summary>
        public virtual User User { get; set; }
    }
}
