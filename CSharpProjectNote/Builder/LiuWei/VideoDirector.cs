using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.LiuWei
{
    public class VideoDirector
    {
        public void Construct(VideoBuilder builder)
        {
            if (builder.IsBuildControl)
            {
                builder.BuildControl();
            }
            if (builder.IsBuildLoveList)
            {
                builder.BuildLoveList();
            }
            if (builder.IsBuildMainWindow)
            {
                builder.BuildMainWindow();
            }
            if (builder.IsBuildMenu)
            {
                builder.BuildMainMenu();
            }
            if (builder.IsBuildPalyList)
            {
                builder.BuildPalyList();
            }

        }
    }
}
