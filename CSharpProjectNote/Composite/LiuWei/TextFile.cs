using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.LiuWei
{
    /// <summary>
    /// 叶子节点(文本文件)
    /// </summary>
    public class TextFile : AbstractFile
    {
        public TextFile(string name)
            : base(name)
        { }

        public override void AddFile(AbstractFile file)
        {
            throw new Exception("TextFile 不支持该方法");
        }
        public override void RemoveFile(AbstractFile file)
        {
            throw new Exception("TextFile 不支持该方法");
        }
        public override void KillVirus()
        {
            Console.WriteLine("---对文本文件 " + Name + " 进行杀毒....");
        }
    }
}
