using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auto.Lock.Cache
{
    public class Cachecs
    {
        protected Hashtable collection = Hashtable.Synchronized(new Hashtable());

        /// <summary>
        /// 清空缓存
        /// </summary>
        public void Clear()
        {
            collection = Hashtable.Synchronized(new Hashtable());
        }
        /// <summary>
        /// 根据KEY取值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public object Get(object key)
        {
            return key ?? collection[key];
        }


        /// <summary>
        /// 存值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Put(object key, object value)
        {
            try
            {
                collection.Add(key, value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 根据key设置已存在缓存对象新值
        /// </summary>
        /// <param name="key">对象KEY</param>
        /// <param name="obj">对象</param>
        public void Set(object key, object obj)
        {
            collection[key] = obj;
        }

        /// <summary>
        /// 根据KEY删除缓存
        /// </summary>
        /// <param name="key"></param>

        public void Remove(object key)
        {
            collection.Remove(key);
        }

        public Hashtable getCurrentHashtable()
        {
            return collection;
        }
    }
}