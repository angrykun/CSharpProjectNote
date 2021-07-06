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
        //public EFDbContext(DbContextOptions<EFDbContext> options) : base(options)
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=demo;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasKey(x => x.Id);
            modelBuilder.Entity<Order>().OwnsOne(x => x.Address);
        }
    }
}
