using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using EF.Core;
using EF.Data;

namespace EF.Test
{
    /// <summary>
    /// ConsumerTest 的摘要说明
    /// </summary>
    [TestClass]
    public class ConsumerTest
    {
        [TestMethod]
        public void CustomerOrderTest()
        {
            Database.SetInitializer<EFDbContext>(new CreateDatabaseIfNotExists<EFDbContext>());
            using (var context = new EFDbContext())
            {
                context.Database.Create();
                Customer customer = new Customer()
                {

                    Name = "Raviendra",
                    Email = "raviendra@test.com",
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IP = "1.1.1.1",
                    Orders = new List<Order> {
                        new Order {
                            Quanatity=12,
                            Price=15,
                            AddedDate=DateTime.Now,
                            ModifiedDate=DateTime.Now,
                            IP="1.1.1.1"
                        },
                        new Order {
                            Quanatity=10,
                            Price=25,
                            AddedDate=DateTime.Now,
                            ModifiedDate=DateTime.Now,
                            IP="1.1.1.1"
                        }
                    }
                };
                context.Entry(customer).State = EntityState.Added;
                context.SaveChanges();
            }
        }
    }
}
