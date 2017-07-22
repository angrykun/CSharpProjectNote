using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCDemo.DAL;
using MVCDemo.Models;

namespace MVCDemo.Repositories
{
    public class SysUserRespository : ISysUserRepository
    {
        private AccountContext db = new AccountContext();
        //查询所有用户
        public IQueryable<SysUser> SelectAll()
        {
            return db.SysUers;
        }
        /// <summary>
        /// 通过用户名查找用户
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public SysUser SelectByName(string userName)
        {
            return db.SysUers.FirstOrDefault(s => s.UserName == userName);
        }
        //添加用户
        public void Add(SysUser sysUser)
        {
            db.SysUers.Add(sysUser);
            db.SaveChanges();
        }

        //删除用户
        public bool Delete(int id)
        {
            var sysUser = db.SysUers.Find(id);
            if (sysUser != null)
            {
                db.SysUers.Remove(sysUser);
                db.SaveChanges();
                return true;
            }
            return false;
        }

    }
}