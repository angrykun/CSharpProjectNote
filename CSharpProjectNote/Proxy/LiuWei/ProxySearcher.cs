using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.LiuWei
{
    /// <summary>
    ///代理类
    /// </summary>
    public class ProxySearcher : Searcher
    {
        private RealSearcher realSeacher = null;
        private AccessValidator validator = null;
        private Logger log = null;
        public string DoSearch(string userId, string key)
        {
            if (realSeacher == null)
            {
                realSeacher = new RealSearcher();
            }
            if (validate(userId))
            {
                var result = realSeacher.DoSearch(userId, key);
                Log(result);
                return result;
            }
            else
            {
                return null;
            }
        }
        private bool validate(string userId)
        {
            validator = new AccessValidator();
            return validator.Validator(userId);
        }
        private void Log(string userId)
        {
            log = new Logger();
            log.Log(userId);
        }
    }
}
