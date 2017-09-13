using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.IteratorDemo
{
    public class FriendIterator : IEnumerator
    {
        private readonly Friends friends;
        private int index;
        private Friend current;
        internal FriendIterator(Friends friends)
        {
            this.friends = friends;
            index = 0;
        }
        public object Current
        {
            get
            {
                return current;
            }
        }
        public bool MoveNext()
        {
            if (index + 1 > friends.Count)
            { return false; }
            else
            {
                current = friends[index];
                index++;
                return true;
            }
        }

        public void Reset() { index = 0; }
    }
}
