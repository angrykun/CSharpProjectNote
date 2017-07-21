using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Reflection;

namespace EF.Data
{
    public class EFDbContext : DbContext
    {
        public EFDbContext() : base("name=DbConnectionString")
        {

        }
        /// <summary>
        /// 在数据库上下文(EFDbContext)初始化完成时，调用
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            {
                var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                    .Where(type => !string.IsNullOrEmpty(type.Namespace))
                    .Where(type => type.BaseType != null && type.BaseType.IsGenericType
                    && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
                foreach (var type in typesToRegister)
                {
                    dynamic configurationInstance = Activator.CreateInstance(type);
                    modelBuilder.Configurations.Add(configurationInstance);
                }
                base.OnModelCreating(modelBuilder);
            }
        }
    }
}
