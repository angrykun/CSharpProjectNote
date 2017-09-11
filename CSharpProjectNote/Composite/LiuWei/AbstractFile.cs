using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.LiuWei
{
    /// <summary>
    /// 抽象构件类
    /// </summary>
    public abstract class AbstractFile
    {
        public string Name { get; set; }
        public AbstractFile(string name)
        {
            Name = name;
        }  
        public abstract void AddFile(AbstractFile file);
        public abstract void RemoveFile(AbstractFile file);
        public abstract void KillVirus();
    }
}
