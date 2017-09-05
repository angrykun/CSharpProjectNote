using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using DapperDemo.Entity;
using MySql.Data.MySqlClient;

namespace DapperDemo
{
    public class DapperCRUD
    {
        #region 链接字符串
        /// <summary>
        /// 链接字符串
        /// </summary>
        private static string ConnectionString
        {
            get
            {
                string connection = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString.ToString();
                return connection;
            }
        }
        #endregion


        #region 连接数据库
        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <returns></returns>
        private MySqlConnection OpenConnection()
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            conn.Open();
            return conn;

        }
        #endregion

        #region 一对一映射
        /// <summary>
        /// 一对一映射
        /// </summary>
        public void OneToOne()
        {
            List<Customer> userList = new List<Customer>();
            using (IDbConnection conn = OpenConnection())
            {
                const string query = @" select A.UserId,A.UserName,A.PasswordHash as Password,A.Email,A.PhoneNumber,A.IsFirstTimeLogin,A.AccessFailedCount,
                                        A.CreationDate,A.IsActive,C.RoleId,C.RoleName from  test.CICUser A
                                        inner join test.CICUserRole  B on A.UserId=B.UserId
                                        inner join test.CICRole C on B.RoleId=C.RoleId ";
                userList = conn.Query<Customer, Role, Customer>(query, (user, role) =>
                {
                    user.Role = role; return user;
                },
                    null, null, true, "RoleId", null, null).ToList();

                if (userList.Count > 0)
                {
                    userList.ForEach(user =>
                    {
                        Console.WriteLine("UserName:" + user.UserName);
                        Console.WriteLine("Password:" + user.Password);
                        Console.WriteLine("Role:" + user.Role.RoleName);
                        Console.WriteLine("--------------------------");
                    });
                }
            }
        }
        #endregion


        #region 一对多映射
        public void OnToMany()
        {
            List<User> userList = new List<User>();
            using (IDbConnection conn = OpenConnection())
            {
                const string query = @" select A.UserId,A.UserName,A.PasswordHash as Password,A.Email,A.PhoneNumber,A.IsFirstTimeLogin,A.AccessFailedCount,
                                        A.CreationDate,A.IsActive,C.RoleId,C.RoleName from  test.CICUser A
                                        left join test.CICUserRole  B on A.UserId=B.UserId
                                        left join test.CICRole C on B.RoleId=C.RoleId ";
                var lookUp = new Dictionary<int, User>();
                userList = conn.Query<User, Role, User>(query, (user, role) =>
                {

                    User u;
                    if (!lookUp.TryGetValue(user.UserId, out u))
                    {
                        lookUp.Add(user.UserId, u = user);
                    }
                    u.Role.Add(role);
                    return u;
                }, null, null, true, "RoleId", null, null).ToList();
               

                if (userList.Count > 0)
                {
                    userList.ForEach(user =>
                    {
                        Console.WriteLine("UserName:" + user.UserName);
                        Console.WriteLine("Password:" + user.Password);
                        Console.WriteLine("Role:" + user.Role.First().RoleName);
                        Console.WriteLine("--------------------------");
                    });
                }
            }
        }
        #endregion


    }
}
