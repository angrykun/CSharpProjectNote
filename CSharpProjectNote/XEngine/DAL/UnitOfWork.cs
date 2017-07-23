using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XEngine.Responistories;
using XEngine.Models;

namespace XEngine.DAL
{
    /// <summary>
    /// 负责解决context不一致问题
    /// </summary>
    public class UnitOfWork : IDisposable
    {
        private XEngineContext context = new XEngineContext();

        private GenericResponsitory<SysUser> sysUserResponsitory;
        private GenericResponsitory<SysRole> sysRoleResponsitory;
        private GenericResponsitory<SysUserRole> sysUserRoleResponsitory;

        public IGenericResponsitory<SysUser> SysUserResponsitory
        {
            get
            {
                if (this.sysUserResponsitory == null)
                {
                    this.sysUserResponsitory = new GenericResponsitory<SysUser>(context);
                }
                return sysUserResponsitory;
            }
        }

        public IGenericResponsitory<SysRole> SysRoleResponsitory
        {
            get
            {
                if (this.sysRoleResponsitory == null)
                {
                    this.sysRoleResponsitory = new GenericResponsitory<SysRole>(context);
                }
                return sysRoleResponsitory;
            }
        }

        public IGenericResponsitory<SysUserRole> SysUserRoleResponsitory
        {
            get
            {
                if (this.sysUserRoleResponsitory == null)
                {
                    this.sysUserRoleResponsitory = new GenericResponsitory<SysUserRole>(context);
                }
                return this.sysUserRoleResponsitory;
            }
        }

        #region Save&Dispose

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

        #endregion Save&Dispose
    }
}