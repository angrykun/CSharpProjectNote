using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.LiuWei
{
    /// <summary>
    /// 抽象操作系统实现类：实现接口
    /// </summary>
    public interface ImageImpl
    {
        /// <summary>
        /// 显示像素矩阵
        /// </summary>
        /// <param name="m"></param>
        void DoPaint(Matrix m);
    }
}
