using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace EF.Data.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            this.HasKey(s => s.ID);

            //给ID配置自动增长
            this.Property(s => s.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //配置字段
            this.Property(s => s.UserName).IsRequired().HasColumnType("nvarchar").HasMaxLength(25);
            this.Property(s => s.Email).IsRequired().HasColumnType("nvarchar").HasMaxLength(25);
            this.Property(s => s.AddedDate).IsRequired();
            this.Property(s => s.ModifiedDate).IsRequired();
            this.Property(s => s.IP);

            //配置表
            this.ToTable("User");
        }
    }
}
