using System;
using System.Collections.Generic;
using System.Text;
using EFCoreDemo.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo
{
    public class EFDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                //.LogTo(Console.WriteLine)
                //.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTrackingWithIdentityResolution )
                //.EnableSensitiveDataLogging() //启用敏感数据日志记录
                .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=demo;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasKey(x => x.Id);
            //配置值对象
            modelBuilder.Entity<Order>().OwnsOne(x => x.Address);


            #region 表拆分，允许将两个或多个实体映射到单行
            modelBuilder.Entity<Order>(ob =>
               {
                   ob.ToTable("Orders");
                   ob.Property(o => o.OrderStatus).HasColumnName("Status");
                   ob.HasOne(o => o.DetailedOrder).WithOne().HasForeignKey<DetailedOrder>(o => o.Id);
               });
            modelBuilder.Entity<DetailedOrder>(dob =>
            {
                dob.ToTable("Orders");
                //将映射DetailOrder.Status到相同的列Order.Status
                dob.Property(o => o.Status).HasColumnName("Status");
            });
            #endregion

            //配置阴影属性
            modelBuilder.Entity<Blog>().Property<DateTime>("LastUpdated");

            //配置序列设置
            modelBuilder.HasSequence<int>("OrderNumbers", "shared")
                .StartsAt(1000)
                .IncrementsBy(5);
        }
    }
}
