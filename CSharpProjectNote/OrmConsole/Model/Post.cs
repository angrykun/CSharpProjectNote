/************************************************************************************ 
 * Copyright (c) 2021 上海浅银互联网科技有限公司 版权所有 All Rights Reserved.
 * 文件名：  OrmConsole.Model.Post 
 * 版本号：  V1.0.0.0 
 * 创建人：wangkun
 * 电子邮箱：wangkun@qianyinkeji.cn
 * 创建时间：2021-03-26 16:52:13 
 * 描述    :
 * =====================================================================
 * 修改时间：2021-03-26 16:52:13 
 * 修改人  ：  
 * 版本号  ：V1.0.0.0 
 * 描述    ：
*************************************************************************************/

using OrmConsole.Mapping;
using System;

namespace OrmConsole.Model
{
    [TableName("T_Posts")]
    public class Post : BaseModel
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Url { get; set; }
        public string Html { get; set; }
        public string Markdown { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
