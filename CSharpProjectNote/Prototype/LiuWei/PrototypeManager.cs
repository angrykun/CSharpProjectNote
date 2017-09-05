using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.LiuWei
{
    /// <summary>
    /// 原型管理器 (饿汉单例模式)
    /// </summary>
    public class PrototypeManager
    {
        //定义hashtable，用于存储原型对象
        private Hashtable ht = new Hashtable();
        private static PrototypeManager pm = new PrototypeManager();
        private PrototypeManager()
        {
            ht.Add("far", new FAR());
            ht.Add("srs", new SRS());
        }
        /// <summary>
        /// 添加一个公文对象
        /// </summary>
        /// <param name="key"></param>
        /// <param name="doc"></param>
        public void AddOfficialDocument(string key, OfficialDocument doc)
        {
            ht.Add(key, doc);
        }
        /// <summary>
        /// 返回一个公文对象
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public OfficialDocument GetOfficialDocument(string key)
        {
            return ((OfficialDocument)ht[key]).Clone();
        }
        /// <summary>
        /// 返回公文管理器对象
        /// </summary>
        /// <returns></returns>
        public static PrototypeManager GetPrototypeManager()
        {
            return pm;
        }
    }
}
