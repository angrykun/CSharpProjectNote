/************************************************************************************ 
 * Copyright (c) 2021 �Ϻ�ǳ���������Ƽ����޹�˾ ��Ȩ���� All Rights Reserved.
 * �ļ�����  OrmConsole.Mapping.TableNameAttribute 
 * �汾�ţ�  V1.0.0.0 
 * �����ˣ�wangkun
 * �������䣺wangkun@qianyinkeji.cn
 * ����ʱ�䣺2021-03-26 17:18:50 
 * ����    :
 * =====================================================================
 * �޸�ʱ�䣺2021-03-26 17:18:50 
 * �޸���  ��  
 * �汾��  ��V1.0.0.0 
 * ����    ��
*************************************************************************************/

using System;

namespace OrmConsole.Mapping
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TableNameAttribute : OrmAbstractAttribute
    {

        public TableNameAttribute(string name) : base(name)
        {

        }
    }
}
