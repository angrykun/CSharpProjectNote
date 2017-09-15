using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.LearningHard
{
    /// <summary>
    /// 负责人 (可以保存多个还原点)
    /// </summary>
    public class CaretakerGrade
    {
        public Dictionary<string, ContactMemento> ContactMementoDic { get; set; }
        public CaretakerGrade()
        {
            ContactMementoDic = new Dictionary<string, ContactMemento>();
        }
    }
}
