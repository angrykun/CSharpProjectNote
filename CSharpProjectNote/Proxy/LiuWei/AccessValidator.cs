using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.LiuWei
{
    /// <summary>
    /// 身份验证类
    /// </summary>
    public class AccessValidator
    {
        public bool Validator(string userId)
        {
            Console.WriteLine("在数据库中验证用户:" + userId + ",是否是合法用户？");
            if (userId.Equals("杨过"))
            {
                Console.WriteLine(userId + ",用户登录成功！");
                return true;
            }
            else
            {
                Console.WriteLine(userId + ",用户登录失败！");
                return false;
            }
        }
    }
}
