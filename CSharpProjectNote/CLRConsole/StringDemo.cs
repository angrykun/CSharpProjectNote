/************************************************************************************ 
 * Copyright (c) 2021 �Ϻ�ǳ���������Ƽ����޹�˾ ��Ȩ���� All Rights Reserved.
 * �ļ�����  StringDemo.StringDemo 
 * �汾�ţ�  V1.0.0.0 
 * �����ˣ�wangkun
 * �������䣺wangkun@qianyinkeji.cn
 * ����ʱ�䣺2021-03-25 11:19:09 
 * ����    :
 * =====================================================================
 * �޸�ʱ�䣺2021-03-25 11:19:09 
 * �޸���  ��  
 * �汾��  ��V1.0.0.0 
 * ����    ��
*************************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace CLRConsole
{
    class StringDemo
    {
        static void Show()
        {
            string result = "Hello" + "world";
            Console.WriteLine(result);
        }

        public static void Show2()
        {
            int i = -10;
            int j = 20;
            int k = 30;
            Console.WriteLine(i + k + j);
        }

        public static void Show3()
        {
            int i = 1;
            int j = 2;
            int k = 3;
            string l = "4";
            string answer = i + j + k + l;
            //string answer = l + i + j + k;
            Console.WriteLine(answer);
        }

        public static void Show4()
        {
            string strr = "abc";
            string str1 = "a" + "b" + "c";

            string str = "a";
            str += "b";
            str += "c";

            string a = "a";
            string b = "b";
            string c = "c";
            string str2 = a + b + c;

            string str3 = $"{a}{b}{c}";

            string str4 = $"a{b}{c}";

            Console.WriteLine(object.ReferenceEquals(str1, strr));
        }
    }
}
