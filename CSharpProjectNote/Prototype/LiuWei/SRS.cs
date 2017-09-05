using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.LiuWei
{
    public class SRS : OfficialDocument
    {    /// <summary>
         /// 浅克隆 
         /// </summary>
         /// <returns></returns>
        public OfficialDocument Clone()
        {
            OfficialDocument far = null;
            try
            {
                far = MemberwiseClone() as OfficialDocument;
            }
            catch (Exception ex)
            {
                Console.WriteLine("不支持复制");
            }
            return far;
        }

        public void Display()
        {
            Console.WriteLine("《软件需求规格说明书》");
        }
    }
}
