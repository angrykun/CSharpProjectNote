/************************************************************************************ 
 * Copyright (c) 2021 �Ϻ�ǳ���������Ƽ����޹�˾ ��Ȩ���� All Rights Reserved.
 * �ļ�����  OrmConsole.Mapping.OrmAbstractAttribute 
 * �汾�ţ�  V1.0.0.0 
 * �����ˣ�wangkun
 * �������䣺wangkun@qianyinkeji.cn
 * ����ʱ�䣺2021-03-26 17:18:20 
 * ����    :
 * =====================================================================
 * �޸�ʱ�䣺2021-03-26 17:18:20 
 * �޸���  ��  
 * �汾��  ��V1.0.0.0 
 * ����    ��
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
