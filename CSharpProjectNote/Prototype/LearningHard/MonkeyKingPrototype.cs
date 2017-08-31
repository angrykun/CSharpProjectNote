using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.LearningHard
{   
    /// <summary>
    /// 孙悟空原型
    /// </summary>
    public abstract class MonkeyKingPrototype
    {
        public string Id { get; set; }
        public MonkeyKingPrototype(string id)
        {
            Id = id;
        }
        //克隆方法，即孙大圣说："变"
        public abstract MonkeyKingPrototype Clone();
    }
}
