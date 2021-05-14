using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.IteratorDemo
{
    /// <summary>
    /// C# 2.0 中使用yield return xx;实现GetEnumerator()方法，
    /// </summary>
    public class FriendsUpgrade : IEnumerable
    {
        private Friend[] friendarray;
        public FriendsUpgrade()
        {
            friendarray = new Friend[] {
                new Friend("HaHa"),
                new Friend("Laught"),
                new Friend("TestName")
            };

        }
        public Friend this[int index]
        {
            get { return friendarray[index]; }
        }
        public int Count
        {
            get { return friendarray.Length; }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < friendarray.Length; i++)
            {
                yield return i;
            }
        }
    }
}
