using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCDemo.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MVCDemo.DAL
{
    public class AccountContext : DbContext
    {
        /**
         * 指定一个连接字符串
         * **/
        public AccountContext() : base("AccountContext")
        { }

        /**
         * Entity Set 对应数据库中的一张表
         * 一个Entity对应表中的一行
         * **/
        public DbSet<SysUser> SysUers { get; set; }
        public DbSet<SysRole> SysRoles { get; set; }
        public DbSet<SysUserRole> SysUserRoles { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //指定单数形式的表名
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}