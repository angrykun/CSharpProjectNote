using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.LiuWei
{
    /// <summary>
    /// 抽象图像类：抽象类
    /// </summary>
    public abstract class ImageClass
    {
        public ImageImpl impl { get; set; }
        public abstract void ParseFile(string fileName);
    }
}
