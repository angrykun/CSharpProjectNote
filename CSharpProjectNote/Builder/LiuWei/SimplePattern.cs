using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.LiuWei
{
 public   class SimplePattern   :VideoBuilder
    {
        private VideoSoftware product = new VideoSoftware();
        public override void BuildControl()
        {
            product.Add("控制条");
        }                                  
        public override void BuildMainWindow()
        {
            product.Add("主窗口");
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
