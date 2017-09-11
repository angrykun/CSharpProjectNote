using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmitMapper;
using EmitMapperDemo.TestClass;
using EmitMapper.MappingConfiguration;

namespace EmitMapperDemo
{
    /// <summary>
    ///  EmitMapper 是一个开源实体映射框架，地址：http://emitmapper.codeplex.com/。
    ///  EmitMapper映射效率比较高，接近硬编码，EmitMapper 采用emit方式在运行时动态
    ///  生成IL，而其他映射框架多是采用反射机制，此外，EmitMapper最大限度减少了
    ///  拆箱和装箱操作和映射过程中的额外调用。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Source src = new Source
            {
                A = 1,
                B = 0M,
                C = "2017/09/06",
                D = new Inner
                {
                    D2 = Guid.NewGuid()
                },
                E = "test"
            };
            List<Source> source_list = new List<Source> {
                new Source {
                     A = 1,
                    B = 0M,
                    C = "2017/09/06",
                    D = new Inner
                    {
                        D2 = Guid.NewGuid()
                    },
                    E = "test"
                }
            };

            Dest dest = new Dest();
            List<Dest> dest_list = new List<Dest>();
            //ObjectMapperManager.DefaultInstance.GetMapper<Source, Dest>(new DefaultMapConfig().ConvertGeneric(typeof(List<>), typeof(List<>), new DefaultCustomConverterProvider(typeof(List<>)).Map(source_list, dest_list);
        }
    }
}
