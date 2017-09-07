using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.LiuWei
{
    /// <summary>
    /// 容器节点(文件夹)
    /// </summary>
    public class FileFolder : AbstractFile
    {
        private IList<AbstractFile> file_list = new List<AbstractFile>();
        public FileFolder(string name) :
            base(name)
        { }

        public override void AddFile(AbstractFile file)
        {
            file_list.Add(file);
        }
        public override void RemoveFile(AbstractFile file)
        {
            file.RemoveFile(file);
        }
        public override void KillVirus()
        {
            Console.WriteLine("***对文件夹："+Name+"****");
            foreach (var file in file_list)
            {
                file.KillVirus();
            }
        }
    }
}
