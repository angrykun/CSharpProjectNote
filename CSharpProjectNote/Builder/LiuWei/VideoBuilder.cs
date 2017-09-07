using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.LiuWei
{
    /// <summary>
    /// 抽象建造者
    /// </summary>
    public abstract class VideoBuilder
    {

        /// <summary>
        /// 创建菜单
        /// </summary>
        public virtual void BuildMainMenu() { }
        public virtual bool IsBuildMenu { get { return false; } }

        /// <summary>
        /// 播放列表
        /// </summary>
        public virtual void BuildPalyList() { }
        public virtual bool IsBuildPalyList { get { return false; } }


        /// <summary>
        /// 创建窗体
        /// </summary>
        public abstract void BuildMainWindow();
        public virtual bool IsBuildMainWindow { get { return false; } }
        /// <summary>
        /// 创建控制条
        /// </summary>
        public abstract void BuildControl();
        public virtual bool IsBuildControl { get { return false; } }

        /// <summary>
        /// 收藏列表
        /// </summary>
        public virtual void BuildLoveList() { }
        public virtual bool IsBuildLoveList { get { return false; } }

        public abstract VideoSoftware GetVideoSoftwarePattern();

    }
}
