/************************************************************************************ 
 * Copyright (c) 2021 �Ϻ�ǳ���������Ƽ����޹�˾ ��Ȩ���� All Rights Reserved.
 * �ļ�����  OrmConsole.OrmExtend 
 * �汾�ţ�  V1.0.0.0 
 * �����ˣ�wangkun
 * �������䣺wangkun@qianyinkeji.cn
 * ����ʱ�䣺2021-03-26 17:22:01 
 * ����    :
 * =====================================================================
 * �޸�ʱ�䣺2021-03-26 17:22:01 
 * �޸���  ��  
 * �汾��  ��V1.0.0.0 
 * ����    ��
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
