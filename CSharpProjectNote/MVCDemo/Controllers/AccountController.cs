using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;
using MVCDemo.DAL;
using PagedList;
using System.Data.Entity;

namespace MVCDemo.Controllers
{
    public class AccountController : Controller
    {
        private AccountContext db = new AccountContext();

        // GET: Account
        public ActionResult Index(string sortOrder, string searchString, string currentFilter, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.CurrentFilter = searchString;

            var users = db.SysUers.Include(s => s.SysDepartment);
            if (!string.IsNullOrEmpty(searchString))
            {
                users = users.Where(u => u.UserName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    users = users.OrderByDescending(u => u.UserName);
                    break;
                default:
                    users = users.OrderBy(u => u.UserName);
                    break;
            }
            int pageSize = 3;
            int pageNumber = (page ?? 1);

            return View(users.ToPagedList(pageNumber, pageSize));
        }

        #region 登录
        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            //获取表单数据
            string email = fc["inputEmail3"];
            string password = fc["inputPassword3"];
            var user = db.SysUers.Where(s => s.Email == email && s.Password == password);
            if (user.Count() > 0)
            {
                ViewBag.LoginState = email + " 登录后。。。";
            }
            else
            {
                ViewBag.LoginState = email + " 用户不存在。。。";
            }

            return View();
        }
        #endregion

        #region 注册  
        /// <summary>
        /// 注册
        /// </summary>
        /// <returns></returns>
        public ActionResult Register()
        {
            return View();
        }
        #endregion

        #region Create
        /// <summary>
        /// 新增
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(SysUser sysUser)
        {
            if (ModelState.IsValid)
            {
                db.SysUers.Add(sysUser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("UserName", "userName Error");
            return View();

        }
        #endregion

        #region Edit
        public ActionResult Edit(int id)
        {
            var sysUser = db.SysUers.Find(id);
            return View(sysUser);
        }
        [HttpPost]
        public ActionResult Edit(SysUser sysUser)
        {
            db.Entry(sysUser).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion

        #region delete
        public ActionResult Delete(int id)
        {
            var sysUSer = db.SysUers.Find(id);

            return View(sysUSer);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var sysUser = db.SysUers.Find(id);
            db.SysUers.Remove(sysUser);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion

        /// <summary>
        /// 查询用户及角色
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(int id)
        {
            var user = db.SysUers.Find(id);
            return View(user);
        }

    }
}