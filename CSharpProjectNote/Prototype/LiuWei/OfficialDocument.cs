using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.LiuWei
{
    /// <summary>
    /// 抽象公文接口
    /// </summary>
    public interface OfficialDocument
    {
        OfficialDocument Clone();
        void Display();
    }
}
