using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using XEngine.Models;

namespace XEngine.DAL
{
    public class XEngineInitializer : DropCreateDatabaseIfModelChanges<XEngineContext>
    {
        protected override void Seed(XEngineContext context)
        {
            var sysUser = new List<SysUser> {
                new SysUser() { ID=1,Name="ZS",CName="张三",Email="zs@xengine.com",Password="1",ModifiedDate=DateTime.Now},
                new SysUser() { ID=2,Name="LS",CName="李四",Email="ls@xengine.com",Password="1",ModifiedDate=DateTime.Now},
                new SysUser() { ID=1,Name="WW",CName="王五",Email="ww@xengine.com",Password="1",ModifiedDate=DateTime.Now}
            };
            sysUser.ForEach(s => context.SysUsers.Add(s));
            context.SaveChanges();

            var sysRole = new List<SysRole> {
                new SysRole() {ID=1,Name="Administrator",CName="管理员",Description="我是管理员",ModifiedDate=DateTime.Now },

                new SysRole() {ID=1,Name="General Users",CName="一般用户",Description="我是一般用户",ModifiedDate=DateTime.Now }
            };
            sysRole.ForEach(s => context.SysRoles.Add(s));
            context.SaveChanges();

            var sysUserRole = new List<SysUserRole> {
                new SysUserRole() { SysUserID=1, SysRoleID=1,ModifiedDate=DateTime.Now},

                new SysUserRole() { SysUserID=1, SysRoleID=2,ModifiedDate=DateTime.Now},

                new SysUserRole() { SysUserID=2, SysRoleID=1,ModifiedDate=DateTime.Now},

                new SysUserRole() { SysUserID=3, SysRoleID=2,ModifiedDate=DateTime.Now}
            };
        }
    }
}