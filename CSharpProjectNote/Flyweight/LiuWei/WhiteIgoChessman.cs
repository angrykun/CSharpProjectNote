using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.LiuWei
{
    /// <summary>
    /// 具体享元类
    /// </summary>
    public class WhiteIgoChessman : IgoChessman
    {
        public override string GetColor()
        {
            return "白色";
        }
    }
}
