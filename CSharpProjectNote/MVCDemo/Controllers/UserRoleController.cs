using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.ViewModels;
using MVCDemo.DAL;
using MVCDemo.Models;
using System.Data.Entity;

namespace MVCDemo.Controllers
{
    public class UserRoleController : Controller
    {
        private AccountContext db = new AccountContext();

        // GET: UserRole
        public ActionResult Index(int? id)
        {
            var viewModel = new UserRoleIndexData();
            viewModel.SysUsers = db.SysUers
                .Include(u => u.SysDepartment)
                .Include(u => u.SysUserRoles.Select(ur => ur.SysRole))
                .OrderBy(u => u.UserName).ToList();
            if (id != null)
            {
                ViewBag.UserID = id;
                viewModel.SysUserRoles = viewModel.SysUsers.Where(u => u.ID == id).Single().SysUserRoles;
                viewModel.SysRoles = (viewModel.SysUserRoles.Where(ur => ur.SysUserID == id.ToString())).Select(ur => ur.SysRole);
            }
            return View(viewModel);
        }
    }
}