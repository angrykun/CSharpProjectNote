using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.LearningHard
{
    /// <summary>
    /// 子系统 注册课程
    /// </summary>
    public class RegisterCourse
    {
        public bool CheckAvailable(string coursername)
        {
            Console.WriteLine("正在验证课程{0}是否人数已满", coursername);
            return true;
        }
    }
}
