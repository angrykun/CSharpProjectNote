/************************************************************************************ 
 * Copyright (c) 2021 上海浅银互联网科技有限公司 版权所有 All Rights Reserved.
 * 文件名：  OrmConsole.OrmExtend 
 * 版本号：  V1.0.0.0 
 * 创建人：wangkun
 * 电子邮箱：wangkun@qianyinkeji.cn
 * 创建时间：2021-03-26 17:22:01 
 * 描述    :
 * =====================================================================
 * 修改时间：2021-03-26 17:22:01 
 * 修改人  ：  
 * 版本号  ：V1.0.0.0 
 * 描述    ：
*************************************************************************************/
using System;
using OrmConsole.Mapping;
using System.Reflection;

namespace OrmConsole
{
    public static class OrmExtend
    {
        public static string GetName(this Type member)
        {
            if (member.IsDefined(typeof(OrmAbstractAttribute), true))
            {
                var attribute = member.GetCustomAttribute<TableNameAttribute>();
                return attribute.Name;
            }
            return member.Name;
        }
    }
}
