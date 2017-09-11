using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.LiuWei
{
    /// <summary>
    /// 具体产品类(视频播放软件)
    /// </summary>
    public class VideoSoftware
    {
        private IList<string> parts = new List<string>();
        public void Add(string part)
        {
            parts.Add(part);
        }
        public void Show()
        {
            Console.WriteLine("---------------");
            foreach (var part in parts)
            {
                Console.WriteLine(part);
            }
            Console.WriteLine("over");
        }
    }
}
