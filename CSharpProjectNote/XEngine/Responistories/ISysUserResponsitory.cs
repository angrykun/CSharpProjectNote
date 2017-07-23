using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XEngine.Models;

namespace XEngine.Responistories
{
    public interface ISysUserResponsitory : IDisposable
    {
        IEnumerable<SysUser> GetUsers();

        SysUser GetUserByID(int userID);

        void InsertUser(SysUser user);

        void DeleteUser(int id);

        void UpdateUser(SysUser user);

        void Save();
    }
}