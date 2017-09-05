using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo.Respository
{
    /// <summary>
    /// 实体类
    /// </summary>
    public class ED_Data
    {
        public string TableName { get; set; }
        public string DataKey { get; set; }
        public string FieldName { get; set; }
        public string Value { get; set; }
        public string Reference { get; set; }
        public int Branch { get; set; }
        public bool InActive { get; set; }
        public DateTime Updated { get; set; }
    }
}
