/************************************************************************************ 
 * Copyright (c) 2021 上海浅银互联网科技有限公司 版权所有 All Rights Reserved.
 * 文件名：  EfCoreMasterSlave.Context.EFCoreAllContext 
 * 版本号：  V1.0.0.0 
 * 创建人：wangkun
 * 电子邮箱：wangkun@qianyinkeji.cn
 * 创建时间：2021-03-29 15:34:00 
 * 描述    :
 * =====================================================================
 * 修改时间：2021-03-29 15:34:00 
 * 修改人  ：  
 * 版本号  ：V1.0.0.0 
 * 描述    ：
*************************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace EfCoreMasterSlave.Context
{
    public class EFCoreAllContext : DbContext
    {
        private string strConn = string.Empty;
        public EFCoreAllContext(string conn)
        {
            strConn = conn;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(strConn);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<>()
        }
    }
}
