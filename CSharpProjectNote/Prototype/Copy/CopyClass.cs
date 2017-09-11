using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq.Expressions;

namespace Prototype.Copy
{
    /**
     * 深拷贝和浅拷贝
     * 
     * 深拷贝：无论原型对象成员变量是值类型还是引用类型，都将复制一份
     * 给克隆对象，深拷贝将原型对象所有引用对象变量也复制一份给克隆对象。
     * （实现方式有：反射，序列化，表达式树）
     * 
     *  浅拷贝：如果原型对象的成员变量是值类型，将复制一份给克隆对象；
     *  如果原型对象中的成员变量是引用类型，则将引用对象地址复制一份
     *  给克隆对象，也就是说原型对象和克隆对象的成员变量指向相同内存地址。
     *  浅克隆中，当对象被复制时只复制它本身和其中包含的值类型成员变量，
     *  引用类型成员变量并没有被复制。 （使用Object基类的MemberwiseClone()方法）
     * **/
    public class CopyClass
    {
        #region 浅拷贝
        /// <summary>
        /// 浅拷贝
        /// </summary>
        public void Method()
        {
            Address address = new Address
            {
                Phone = "18565896558",
                Name = "Tom",
                DetailAddress = "中国上海市普陀区交通路"
            };
            Order order = new Order
            {
                OrderID = 1000000,
                CreateTime = DateTime.Now,
                AddressModel = address
            };
            Order orderClone = order.Clone();
            Console.WriteLine("order==orderClone? {0}", order == orderClone);
            Console.WriteLine("order.AddressModel==orderClone.AddressModel? {0}", order.AddressModel == orderClone.AddressModel);
            Console.WriteLine("修改浅拷贝对象中引用类型成员变量Name属性为Jerry");
            orderClone.AddressModel.Name = "Jerry";
            Console.WriteLine("order.AddressModel.Name={0},orderClone.AddressModel.Name={1}", order.AddressModel.Name, orderClone.AddressModel.Name);
            Console.WriteLine("order.AddressModel==orderClone.AddressModel? {0}", order.AddressModel == orderClone.AddressModel);
        }
        #endregion

        public void MethodTwo()
        {
            Address address = new Address
            {
                Phone = "18565896558",
                Name = "Tom",
                DetailAddress = "中国上海市普陀区交通路"
            };
            Order order = new Order
            {
                OrderID = 1000000,
                CreateTime = DateTime.Now,
                AddressModel = address
            };
            Order orderClone = DeepCloneWithExpression(order);
            Console.WriteLine("order==orderClone? {0}", order == orderClone);
            Console.WriteLine("order.AddressModel==orderClone.AddressModel? {0}", order.AddressModel == orderClone.AddressModel);
            Console.WriteLine("修改浅拷贝对象中引用类型成员变量Name属性为Jerry");
            orderClone.AddressModel.Name = "Jerry";
            Console.WriteLine("order.AddressModel.Name={0},orderClone.AddressModel.Name={1}", order.AddressModel.Name, orderClone.AddressModel.Name);
            Console.WriteLine("order.AddressModel==orderClone.AddressModel? {0}", order.AddressModel == orderClone.AddressModel);
        }

        #region 反射实现深拷贝
        public T DeepCloneWithReflection<T>(T obj)
        {
            Type type = obj.GetType();
            //如果是字符串或者值类型，则直接返回
            if (obj is string || type.IsValueType) return obj;

            if (type.IsArray)
            {
                Type elementType = Type.GetType(type.FullName.Replace("[]", string.Empty));
                var array = obj as Array;
                Array cloned = Array.CreateInstance(elementType, array.Length);
                for (int i = 0; i < array.Length; i++)
                {
                    cloned.SetValue(DeepCloneWithReflection(array.GetValue(i)), i);
                }
                return (T)Convert.ChangeType(cloned, obj.GetType());
            }

            object retval = Activator.CreateInstance(obj.GetType());

            PropertyInfo[] properties = obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (var property in properties)
            {
                var propertyValue = property.GetValue(obj, null);
                if (propertyValue == null)
                    continue;
                property.SetValue(retval, DeepCloneWithReflection(propertyValue), null);//循环递归调用
            }
            return (T)retval;
        }
        #endregion


        #region XML序列化和反序列化
        public T DeepCloneWithXmlSerialize<T>(T obj)
        {
            object retval;
            using (MemoryStream ms = new MemoryStream())
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));
                xml.Serialize(ms, obj);
                ms.Seek(0, SeekOrigin.Begin);
                retval = xml.Deserialize(ms);
                ms.Close();
            }
            return (T)retval;
        }
        #endregion

        #region 二进制序列化和反序列化
        public T DeepCloneWithBinarySerialize<T>(T obj)
        {
            object retval;
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                //序列化成流
                bf.Serialize(ms, obj);
                ms.Seek(0, SeekOrigin.Begin);
                //反序列化成对象 
                retval = bf.Deserialize(ms);
                ms.Close();
            }
            return (T)retval;
        }
        #endregion

        #region 表达式树实现深拷贝
        public T DeepCloneWithExpression<T>(T obj)
        {
            ParameterExpression parameterExpression = Expression.Parameter(typeof(T), "p");
            List<MemberBinding> memberBindingList = new List<MemberBinding>();
            foreach (var item in typeof(T).GetProperties())
            {
                if (!item.CanWrite)
                    continue;
                MemberExpression property = Expression.Property(parameterExpression, typeof(T).GetProperty(item.Name));
                MemberBinding memberBinding = Expression.Bind(item, property);
                memberBindingList.Add(memberBinding);
            }
            MemberInitExpression memberInitExpression = Expression.MemberInit(Expression.New(typeof(T)), memberBindingList.ToArray());
            Expression<Func<T, T>> lambda = Expression.Lambda<Func<T, T>>(memberInitExpression, new ParameterExpression[] { parameterExpression });
            return lambda.Compile()(obj);
        }
        #endregion

    }

    /// <summary>
    /// 订单类
    /// </summary>
    [Serializable]
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime CreateTime { get; set; }
        public Address AddressModel { get; set; }

        public Order Clone()
        {
            return MemberwiseClone() as Order;
        }
    }
    /// <summary>
    /// 地址
    /// </summary>
    [Serializable]
    public class Address
    {
        public string Phone { get; set; }
        public string Name { get; set; }
        public string DetailAddress { get; set; }
    }
}
