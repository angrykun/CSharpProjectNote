using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.LiuWei
{
    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            //业务代码
            //调用实现类的方法
            impl.OperationImpl();
            //业务代码
        }
    }
}
