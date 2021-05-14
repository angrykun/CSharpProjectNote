/************************************************************************************ 
 * Copyright (c) 2021 上海浅银互联网科技有限公司 版权所有 All Rights Reserved.
 * 文件名：  OrmConsole.Dal.SqlHelper 
 * 版本号：  V1.0.0.0 
 * 创建人：wangkun
 * 电子邮箱：wangkun@qianyinkeji.cn
 * 创建时间：2021-03-26 14:30:08 
 * 描述    :
 * =====================================================================
 * 修改时间：2021-03-26 14:30:08 
 * 修改人  ：  
 * 版本号  ：V1.0.0.0 
 * 描述    ：
*************************************************************************************/

using System;
using System.Data.SqlClient;
using System.Linq;
using OrmConsole.Mapping;
using OrmConsole.Model;

namespace OrmConsole.Dal
{
    public class SqlHelper
    {

        public static T Find<T>(int id) where T : BaseModel
        {
            var type = typeof(T);
            var properties = type.GetProperties();
            var columnStr = string.Join(",", properties.Select(p => $"[{p.Name}]"));
            var tableName = type.GetName();

            string sql = $"select {columnStr} from  { tableName}  where id={id}";
            var connStr = "Data Source=127.0.0.1;Initial Catalog=meowv_blog;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var t = (T)Activator.CreateInstance(type);
                    foreach (var prop in type.GetProperties())
                    {
                        prop.SetValue(t, reader[prop.Name] is DBNull ? null : reader[prop.Name]);
                    }
                    return t;
                }
                return default(T);
            }
        }
    }
}
