using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XEngine.DAL;
using XEngine.Models;
using XEngine.Responistories;

namespace XEngine.Controllers
{
    public class UserController : Controller
    {
        #region 方法一

        /*  方法一：产生很多冗余代码，会导致更新不一致
         private ISysUserResponsitory userRepository = new SysUserResponsitory();
         public ActionResult Index()
         {
             var users = userRepository.GetUsers().ToList();
             return View(users);
         }*/

        #endregion 方法一

        #region 方法二

        /*方法二，使用泛型Responsitory模式，消除冗余，不必每个实体都创建一个仓储
        //无法解决context不一致问题

        private IGenericResponsitory<SysUser> userRepository = new GenericResponsitory<SysUser>(new DAL.XEngineContext());

        public ActionResult Index()
        {
            var users = userRepository.Get().ToList();
            return View(users);
        }*/

        #endregion 方法二

        #region 方法三

        //解决context上下文不一致

        private UnitOfWork unitOfWOrk = new UnitOfWork();

        public ActionResult Index()
        {
            //不加入任何条件
            //var users = unitOfWOrk.SysUserResponsitory.Get();

            //加入过滤条件
            //var users = unitOfWOrk.SysUserResponsitory.Get(filter: u => u.Name == "ZS");

            //不加入排序条件
            var users = unitOfWOrk.SysUserResponsitory.Get(orderBy: q => q.OrderBy(u => u.Name));

            return View(users);
        }

        #endregion 方法三
    }
}