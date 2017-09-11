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
    public class UserProfileMap : EntityTypeConfiguration<UserProfile>
    {
        public UserProfileMap()
        {
            this.HasKey(s => s.ID);

            this.Property(s => s.FirstName).IsRequired();
            this.Property(s => s.LastName).IsRequired();
            this.Property(s => s.Address).HasMaxLength(100).HasColumnType("nvarchar").IsRequired();

            this.Property(s => s.AddedDate).IsRequired();
            this.Property(s => s.ModifiedDate).IsRequired();
            this.Property(s => s.IP);

            //配置关系[一个用户只能有一个用户详情！！！]
            this.HasRequired(s => s.User).WithRequiredDependent(s => s.UserProfile);

            this.ToTable("UserProfile");
        }
    }
}
