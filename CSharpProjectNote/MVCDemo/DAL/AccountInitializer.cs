using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVCDemo.Models;

namespace MVCDemo.DAL
{
    public class AccountInitializer : DropCreateDatabaseIfModelChanges<AccountContext>
    {
        protected override void Seed(AccountContext context)
        {
            var sysUsers = new List<SysUser> {
                new SysUser() { UserName="Tom",Email="Tom@sohu.com",Password="1"},
                new SysUser() { UserName="Jerry",Email="Jerry@souhu.com", Password="2"}
            };
            sysUsers.ForEach(s => context.SysUers.Add(s));
            context.SaveChanges();

            var sysRoles = new List<SysRole> {
                new SysRole() { RoleName="Administrator",RoleDesc="Administrator has full authorization to perform system administrator"},
                new SysRole() { RoleName="General Users",RoleDesc="General Users can access the shared data tey are authorized for."}
            };
            sysRoles.ForEach(s => context.SysRoles.Add(s));
            context.SaveChanges();
        }
    }
}