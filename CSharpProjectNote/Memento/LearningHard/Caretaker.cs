using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.LearningHard
{
    /// <summary>
    /// 负责人 （目前只能保存一次还原点）
    /// PS：
    /// 负责保存备忘录，但是不能对备忘录的内容进行操作或检查。
    /// 在负责人类中，可以存储一个或多个备忘录对象，它只负责存储对象
    /// 而不能修改对象，也无需知道对象的实现细节。
    /// </summary>
    public class Caretaker
    {
        public ContactMemento ContactM { get; set; }
    }
}
