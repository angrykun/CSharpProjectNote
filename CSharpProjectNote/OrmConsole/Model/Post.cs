/************************************************************************************ 
 * Copyright (c) 2021 �Ϻ�ǳ���������Ƽ����޹�˾ ��Ȩ���� All Rights Reserved.
 * �ļ�����  OrmConsole.Model.Post 
 * �汾�ţ�  V1.0.0.0 
 * �����ˣ�wangkun
 * �������䣺wangkun@qianyinkeji.cn
 * ����ʱ�䣺2021-03-26 16:52:13 
 * ����    :
 * =====================================================================
 * �޸�ʱ�䣺2021-03-26 16:52:13 
 * �޸���  ��  
 * �汾��  ��V1.0.0.0 
 * ����    ��
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
