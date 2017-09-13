﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.LearningHard
{
    /// <summary>
    /// 具体迭代器类
    /// </summary>
    public class ConcreteIterator : Iterator
    {
        private ConcreteList _list;
        private int _index;

        public ConcreteIterator(ConcreteList list)
        {
            _list = list;
            _index = 0;
        }
        public bool MoveNext()
        {
            if (_index < _list.Length)
            {
                return true;
            }
            return false;
        }

        public object GetCurrent()
        {
            return _list.GetElement(_index);
        }
        public void Reset()
        {
            _index = 0;
        }
        public void Next()
        {
            if (_index < _list.Length)
            {
                _index++;
            }
        }
    }
}