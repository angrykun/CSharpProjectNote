/************************************************************************************ 
 * Copyright (c) 2021 上海浅银互联网科技有限公司 版权所有 All Rights Reserved.
 * 文件名：  ConsulDemo.Extension.ConsulOptions 
 * 版本号：  V1.0.0.0 
 * 创建人：wangkun
 * 电子邮箱：wangkun@qianyinkeji.cn
 * 创建时间：2021-05-14 23:55:21 
 * 描述    :
 * =====================================================================
 * 修改时间：2021-05-14 23:55:21 
 * 修改人  ：  
 * 版本号  ：V1.0.0.0 
 * 描述    ：
*************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsulDemo.Extension
{
    public class ConsulOptions
    {
        /// <summary>
        /// 服务名称
        /// </summary>
        public string ServiceName { get; set; }
        /// <summary>
        /// 服务IP地址
        /// </summary>
        public string ServiceIp { get; set; }

        /// <summary>
        /// 服务端口
        /// </summary>
        public int ServicePort { get; set; }
        /// <summary>
        /// 健康检查地址
        /// </summary>
        public string HealthCheck { get; set; }
        /// <summary>
        /// consul地址
        /// </summary>
        public string ConsulAddress { get; set; }
    }
}
