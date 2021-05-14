/************************************************************************************ 
 * Copyright (c) 2021 上海浅银互联网科技有限公司 版权所有 All Rights Reserved.
 * 文件名：  StringDemo.ExpressionDemo 
 * 版本号：  V1.0.0.0 
 * 创建人：wangkun
 * 电子邮箱：wangkun@qianyinkeji.cn
 * 创建时间：2021-03-25 11:19:43 
 * 描述    :
 * =====================================================================
 * 修改时间：2021-03-25 11:19:43 
 * 修改人  ：  
 * 版本号  ：V1.0.0.0 
 * 描述    ：
*************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace StringDemo
{
    /// <summary>
    /// 表达式树
    /// </summary>
    public class ExpressionDemo
    {

        public static void Show()
        {
            Console.WriteLine("--------------Show1-------------");
            Expression<Func<int, int, int>> expression = (a, b) => a + b;
            var parmeter1 = expression.Parameters[0];
            var parmeter2 = expression.Parameters[1];

            BinaryExpression body = (BinaryExpression)expression.Body;
            ParameterExpression left = (ParameterExpression)body.Left;
            ParameterExpression right = (ParameterExpression)body.Right;
            var symbols = body.NodeType;
            int result = expression.Compile()(2, 3);
            Console.WriteLine("表达式：{0}", parmeter1);
            Console.WriteLine("表达式体：{0}", body);
            Console.WriteLine("表达式左边节点：{0}", left);
            Console.WriteLine("表达式右边节点：{0}", right);
            Console.WriteLine("表达式符号：{0}", symbols);
            Console.WriteLine("表达式执行结果：{0}", result);
        }

        public static void Show2()
        {
            Console.WriteLine("--------------Show2-------------");
            int a = 100;
            int b = 200;
            ParameterExpression left = Expression.Parameter(typeof(int), "a");
            ParameterExpression right = Expression.Parameter(typeof(int), "b");

            BinaryExpression binary = Expression.Add(left, right);
            Expression<Func<int, int, int>> expression = Expression.Lambda<Func<int, int, int>>(binary, left, right);
            Console.WriteLine($"{expression.ToString()}");
            Console.WriteLine($"{expression.Compile().Invoke(a, b)}");
        }

        public static void Show3()
        {
            Console.WriteLine("-------------show3-------------");
            Expression<Func<int, int, int>> expression = (m, n) => m * n + m + n + 2;

            //定义变量
            ParameterExpression m1 = Expression.Parameter(typeof(int), "m");
            ParameterExpression n1 = Expression.Parameter(typeof(int), "n");
            ConstantExpression const2 = Expression.Constant(2);

            BinaryExpression multipy = Expression.Multiply(m1, n1);
            BinaryExpression plus1 = Expression.Add(multipy, m1);
            BinaryExpression plus2 = Expression.Add(plus1, n1);
            BinaryExpression plus3 = Expression.Add(plus2, const2);

            Expression<Func<int, int, int>> expressopn2 = Expression.Lambda<Func<int, int, int>>(plus3, m1, n1);

            var result = expression.Compile().Invoke(1, 2);
            var result1 = expressopn2.Compile().Invoke(1, 2);

            Console.WriteLine($"result={result},result1={result1}");
        }


        public static void Show4()
        {
            Console.WriteLine("-------------show4------------");
            Expression<Func<People, bool>> lambda = x => x.Id.ToString().Equals("5");

            var parameterExpression2 = Expression.Parameter(typeof(People), "x");
            var constantExp = Expression.Constant("5");
            FieldInfo field = typeof(People).GetField("Id");
            var fieldExp = Expression.Field(parameterExpression2, field);
            //调用不带参数的toSting()
            var toString = typeof(int).GetMethod("ToString", new Type[] { });
            var toStringExp = Expression.Call(fieldExp, toString, new Expression[0]);

            //找到equals
            var equals = typeof(string).GetMethod("Equals", new Type[] { typeof(string) });
            var equalsExp = Expression.Call(toStringExp, equals, constantExp);

            Expression<Func<People, bool>> expression =
                Expression.Lambda<Func<People, bool>>(equalsExp, parameterExpression2);

            bool result = expression.Compile().Invoke(new People()
            {
                Id = 5,
                Name = "test",
                Age = 29
            });

            Console.WriteLine($"result={result}");  
            var list = new List<string>();
            list.Where(x => x.Equals("5"));
        }

    }

    class People
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }

    }
}
