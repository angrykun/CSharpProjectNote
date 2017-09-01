using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using DapperDemo.Respository;
using System.Data;
using Dapper;

namespace DapperDemo
{
    public class DapperDemo
    {
        /// <summary>
        /// 链接字符串
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                string _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString.ToString();
                return _connectionString;
            }
        }

        #region 打开连接Open
        /// <summary>
        /// mysql connection
        /// </summary>
        /// <returns></returns>
        public MySqlConnection OpenConnection()
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }
        #endregion

        #region 新增记录 Add
        /// <summary>
        /// 新增记录
        /// </summary>
        /// <returns></returns>
        public bool Add(ED_Data model)
        {
            int row = 0;
            //ED_Data model = new ED_Data
            //{
            //    TableName = "123",
            //    DataKey = "123",
            //    FieldName = "123",
            //    Value = "123",
            //    Reference = "123",
            //    Branch = 1,
            //    InActive = false
            //};

            const string query = @"INSERT INTO test.ED_Data(TableName,DataKey,FieldName,Value,Reference,Branch,InActive)
                            VALUES(@TableName, @DataKey, @FieldName, @Value, @Reference, @Branch, @InActive)";
            using (IDbConnection conn = OpenConnection())
            {
                row = conn.Execute(query, model);
            }
            if (row > 0)
            { return true; }

            return false;
        }
        #endregion

        #region 修改记录 Update
        /// <summary>
        /// 修改记录
        /// </summary>
        /// <returns></returns>
        public int Update()
        {
            int row = 0;
            ED_Data model = new ED_Data
            {
                TableName = "123",
                DataKey = "123Test"
            };
            using (IDbConnection conn = OpenConnection())
            {
                const string query = "UPDATE  test.ED_Data SET DataKey=@DataKey where TableName=@TableName";
                row = conn.Execute(query, model);
            }
            return row;
        }
        #endregion

        #region 删除 Delete
        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        public int Delete()
        {
            int row = 0;
            ED_Data model = new ED_Data
            {
                TableName = "123"
            };
            using (IDbConnection conn = OpenConnection())
            {
                const string query = @"DELETE FROM test.ED_Data WHERE TableName=@TableName";
                row = conn.Execute(query, model);
            }
            return row;
        }
        #endregion

        #region 查询单条记录 GetModel
        /// <summary>
        /// 查询单条记录
        /// </summary>
        /// <param name="TableName"></param>
        /// <returns></returns>
        public ED_Data GetModel(string TableName)
        {
            using (IDbConnection conn = OpenConnection())
            {
                const string query = @"SELECT * FROM test.ED_Data E WHERE TableName=@TableName";
                return conn.Query<ED_Data>(query, new { TableName = TableName }).SingleOrDefault();
            }
        }
        #endregion


        #region 查询list 集合 
        public List<ED_Data> GetED_DataList()
        {
            using (IDbConnection conn = OpenConnection())
            {
                const string query = "SELECT * FROM test.ED_Data E";
                return conn.Query<ED_Data>(query, null).ToList();
            }
        }
        #endregion

        #region 事务处理        DeleteColumnCatAndColumn
        /// <summary>
        /// 事务处理
        /// </summary>
        /// <param name="cat"></param>
        /// <returns></returns>
        public int DeleteColumnCatAndColumn(ED_Data cat)
        {

            using (IDbConnection conn = OpenConnection())
            {
                string delete1 = "DELETE FROM test.ED_Data WHERE TableName=@TableName";
                string delete2 = "DELETE1 FROM test.ED_Data WHERE TableName=@TableName";
                int row = 0;
                using (IDbTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        row = conn.Execute(delete1, new { TableName = cat.TableName }, trans, null, null);
                        row += conn.Execute(delete2, new { TableName = cat.TableName }, trans, null, null);
                        trans.Commit();
                        return row;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                    }
                }
                return row;
            }
        }
        #endregion

        #region 执行存储过程
        public void ExecuteStoredProcedure()
        {
            //存储过程参数
            DynamicParameters param = new DynamicParameters();
            param.Add("@params", 1);
            param.Add("@params", 2);
            using (IDbConnection conn = OpenConnection())
            {
                int row = conn.Execute("存储过程名称", param, null, null, CommandType.StoredProcedure);
            }

        }
        #endregion

        #region 批量添加
        public void InsertBatch(List<ED_Data> list)
        {
            const string query = @"INSERT INTO test.ED_Data(TableName,DataKey,FieldName,Value,Reference,Branch,InActive)
                            VALUES(@TableName, @DataKey, @FieldName, @Value, @Reference, @Branch, @InActive)";
            using (IDbConnection conn = OpenConnection())
            {
                conn.Execute(query, list, null, null, null);
            }
        }
        #endregion

    }

}
