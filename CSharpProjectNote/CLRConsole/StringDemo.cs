/************************************************************************************ 
 * Copyright (c) 2021 上海浅银互联网科技有限公司 版权所有 All Rights Reserved.
 * 文件名：  StringDemo.StringDemo 
 * 版本号：  V1.0.0.0 
 * 创建人：wangkun
 * 电子邮箱：wangkun@qianyinkeji.cn
 * 创建时间：2021-03-25 11:19:09 
 * 描述    :
 * =====================================================================
 * 修改时间：2021-03-25 11:19:09 
 * 修改人  ：  
 * 版本号  ：V1.0.0.0 
 * 描述    ：
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
