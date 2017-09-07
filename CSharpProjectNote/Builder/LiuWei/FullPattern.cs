using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.LiuWei
{
    /// <summary>
    /// 具体建造者 （完整模式）
    /// </summary>
    public class FullPattern : VideoBuilder
    {
        private VideoSoftware product = new VideoSoftware();
        public override void BuildControl()
        {
            product.Add("控制条");
        }
        public override void BuildMainMenu()
        {
            product.Add("菜单");
        }
        public override void BuildPalyList()
        {
            product.Add("播放列表");
        }
        public override void BuildMainWindow()
        {
            product.Add("主窗口");
        }
        public override bool IsBuildMenu
        {
            get
            {
                return true;
            }
        }
        public override bool IsBuildPalyList
        {
            get
            {
                return true;
            }
        }
        public override bool IsBuildControl
        {
            get
            {
                return true;
            }
        }
        public override bool IsBuildMainWindow
        {
            get
            {
                return true;
            }
        }
        public override VideoSoftware GetVideoSoftwarePattern()
        {
            return product;
        }
    }
}
