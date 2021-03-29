/************************************************************************************ 
 * Copyright (c) 2021 上海浅银互联网科技有限公司 版权所有 All Rights Reserved.
 * 文件名：  OrmConsole.Mapping.OrmAbstractAttribute 
 * 版本号：  V1.0.0.0 
 * 创建人：wangkun
 * 电子邮箱：wangkun@qianyinkeji.cn
 * 创建时间：2021-03-26 17:18:20 
 * 描述    :
 * =====================================================================
 * 修改时间：2021-03-26 17:18:20 
 * 修改人  ：  
 * 版本号  ：V1.0.0.0 
 * 描述    ：
*************************************************************************************/

using System;

namespace OrmConsole.Mapping
{
    public abstract class OrmAbstractAttribute : Attribute
    {
        public string Name { get; set; }
        public OrmAbstractAttribute(string name)
        {
            Name = name;
        }
    }
}
