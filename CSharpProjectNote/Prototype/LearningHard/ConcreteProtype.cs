using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.LearningHard
{
    /// <summary>
    /// 创建具体原型
    /// </summary>
    public class ConcreteProtype : MonkeyKingPrototype
    {
        public ConcreteProtype(string id) : base(id)
        { }
        /// <summary>
        /// 浅拷贝
        /// </summary>
        /// <returns></returns>
        public override MonkeyKingPrototype Clone()
        {
            //调用MemberwiseClone 方法实现的是浅拷贝
            return (MonkeyKingPrototype)MemberwiseClone();
        }
    }
}
