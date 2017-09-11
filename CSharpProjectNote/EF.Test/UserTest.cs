using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using EF.Core;
using EF.Data;

namespace EF.Test
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void UserUserProfileTest()
        {
            Database.SetInitializer<EFDbContext>(new CreateDatabaseIfNotExists<EFDbContext>());

            using (var db = new EFDbContext())
            {
                //创建数据库
                db.Database.Create();
                User userModel = new User()
                {
                    UserName = "Daniel",
                    Password = "123456",
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IP = "1.1.1.1",
                    Email = "Daniel@163.com",
                    //一个用户，只有一个用户详情
                    UserProfile = new UserProfile()
                    {
                        FirstName = "曹",
                        LastName = "操",
                        AddedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IP = "1.2.3.45",
                        Address = "宝安区 深圳 中国",
                    }
                };
                //设置用户示例状态为Add
                db.Entry(userModel).State = EntityState.Added;
                //保存到数据库中
                db.SaveChanges();
            }
        }
    }
}
