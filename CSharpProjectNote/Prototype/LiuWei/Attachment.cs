using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.LiuWei
{
    /// <summary>
    /// 附件
    /// </summary>
    [Serializable]
    public class Attachment
    {
        public string Name { get; set; }
        public Attachment(string name)
        {
            Name = name;
        }
        public void Download()
        {
            Console.WriteLine("下载附件，文件名为：" + Name);
        }
    }
}
