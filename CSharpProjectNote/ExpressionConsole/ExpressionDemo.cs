/************************************************************************************ 
 * Copyright (c) 2021 �Ϻ�ǳ���������Ƽ����޹�˾ ��Ȩ���� All Rights Reserved.
 * �ļ�����  StringDemo.ExpressionDemo 
 * �汾�ţ�  V1.0.0.0 
 * �����ˣ�wangkun
 * �������䣺wangkun@qianyinkeji.cn
 * ����ʱ�䣺2021-03-25 11:19:43 
 * ����    :
 * =====================================================================
 * �޸�ʱ�䣺2021-03-25 11:19:43 
 * �޸���  ��  
 * �汾��  ��V1.0.0.0 
 * ����    ��
*************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace StringDemo
{
    /// <summary>
    /// ���ʽ��
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
            Console.WriteLine("���ʽ��{0}", parmeter1);
            Console.WriteLine("���ʽ�壺{0}", body);
            Console.WriteLine("���ʽ��߽ڵ㣺{0}", left);
            Console.WriteLine("���ʽ�ұ߽ڵ㣺{0}", right);
            Console.WriteLine("���ʽ���ţ�{0}", symbols);
            Console.WriteLine("���ʽִ�н����{0}", result);
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

            //�������
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
            //���ò���������toSting()
            var toString = typeof(int).GetMethod("ToString", new Type[] { });
            var toStringExp = Expression.Call(fieldExp, toString, new Expression[0]);

            //�ҵ�equals
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
