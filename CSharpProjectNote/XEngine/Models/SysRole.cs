using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace XEngine.Models
{
    public class SysRole
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string CName { get; set; }
        public string Description { get; set; }
        public DateTime ModifiedDate { get; set; }
        public ICollection<SysUserRole> SysUserRoles { get; set; }
    }
}