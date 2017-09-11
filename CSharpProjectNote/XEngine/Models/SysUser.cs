﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace XEngine.Models
{
    public class SysUser
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public string CName { get; set; }
        public string Description { get; set; }
        public DateTime ModifiedDate { get; set; }
        public ICollection<SysUserRole> SysUserRoles { get; set; }
    }
}