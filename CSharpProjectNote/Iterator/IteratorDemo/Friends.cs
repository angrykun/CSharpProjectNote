using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.IteratorDemo
{
    /**
     * 一个类型要能够使用foreach关键字来对其遍历必须实现IEnumerable或IEnumerable<T> 接口
     *（因为foreach语句是迭代语句，要使用foreach必须要有一个迭代器，IEnumerable接口中
     * 就有IEnumerator GetEnumerator()方法是返回迭代器的，所以实现了IEnumerable接口就
     * 必须实现GetEnumerator()方法来返回迭代器）
     *
     * **/

    /// <summary>
    /// 朋友集合（具体聚合类）
    /// </summary>
    public class Friends : IEnumerable
    {
        private Friend[] friendarray;

        public Friends()
        {
            friendarray = new Friend[] {
             new Friend("张三"),
             new Friend("李四"),
             new Friend("王五")
            };
        }

        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Friend this[int index]
        {
            get { return friendarray[index]; }
        }

        /// <summary>
        ///
        /// </summary>
        public int Count
        {
            get { return friendarray.Length; }
        }

        /// <summary>
        /// 实现IEnumerable<T>接口方法
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            return new FriendIterator(this);
        }
    }
}