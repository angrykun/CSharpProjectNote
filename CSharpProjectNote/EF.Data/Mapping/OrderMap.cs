using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace EF.Data.Mapping
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            this.HasKey(s => s.ID);
            //fields  
            Property(t => t.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Quanatity).IsRequired().HasColumnType("tinyint");
            Property(t => t.Price).IsRequired();
            Property(t => t.CustomerId).IsRequired();
            Property(t => t.AddedDate).IsRequired();
            Property(t => t.ModifiedDate).IsRequired();
            Property(t => t.IP);

            //配置关系【一个用户有多个订单，外键是CusyomerId】
            //WillCascadeOnDelete方法用来配置是否级联删除。
            this.HasRequired(s => s.Customer).WithMany(s => s.Orders).HasForeignKey(s => s.CustomerId).WillCascadeOnDelete(true);

            //table  
            ToTable("Orders");
        }
    }
}
