using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XEngine.DAL;
using XEngine.Models;

namespace XEngine.Responistories
{
    public class SysUserResponsitory : ISysUserResponsitory
    {
        private XEngineContext context;

        public SysUserResponsitory()
        {
            this.context = new XEngineContext();
        }

        public IEnumerable<SysUser> GetUsers()
        {
            return context.SysUsers.ToList();
        }

        public SysUser GetUserByID(int userID)
        {
            return context.SysUsers.Find(userID);
        }

        public void InsertUser(SysUser user)
        {
            context.SysUsers.Add(user);
        }

        public void DeleteUser(int userID)
        {
            var user = GetUserByID(userID);
            if (user != null)
            {
                context.SysUsers.Remove(user);
            }
        }

        public void UpdateUser(SysUser user)
        {
            context.Entry(user).State = System.Data.Entity.EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            //因为对象会被Dispose释放，所以需要调用GC.SuppressFinalize来让对象脱离终止队列，防止对象终止被执行两次。
            GC.SuppressFinalize(this);
        }
    }
}