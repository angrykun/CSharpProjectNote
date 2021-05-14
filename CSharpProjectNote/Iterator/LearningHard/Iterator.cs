using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.LearningHard
{
    /// <summary>
    /// 抽象迭代器类
    /// </summary>
    public interface Iterator
    {
        bool MoveNext();
        object GetCurrent();
        void Next();
        void Reset();
    }
}
