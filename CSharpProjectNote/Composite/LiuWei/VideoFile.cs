using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.LiuWei
{
    /// <summary>
    /// 叶子节点 (视频文件)
    /// </summary>
    public class VideoFile : AbstractFile
    {
        public VideoFile(string name)
            : base(name)
        { }

        public override void AddFile(AbstractFile file)
        {
            throw new Exception("VideoFile 不支持该方法");
        }
        public override void RemoveFile(AbstractFile file)
        {
            throw new Exception("VideoFile 不支持该方法");
        }
        public override void KillVirus()
        {
            Console.WriteLine("---对视频文件： " + Name + " 进行杀毒....");
        }
    }
}
