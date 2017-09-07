using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite.LearningHard;
using Composite.LiuWei;

namespace Composite
{
    /**
     * 组合模式：组合多个对象形成树形结构，以表示具有“整体-部分”
     * 关系的层次结构。组合模式对单个对象和组合对象使用具有
     * 一致性，组合模式又可称为“整体-部分”模式。
     * **/
    class Program
    {
        static void Main(string[] args)
        {
            MethodOne();
            MethodTwo();
        }
        #region MethodOne
        static void MethodOne()
        {
            Graphics complexGraphics = new ComplexGraphics("一个复杂图形和两条线段组成的复杂图形");
            complexGraphics.Add(new Line("线段A"));

            Graphics compisiteGC = new ComplexGraphics("一个圆和一条线段组成的复杂图形");
            compisiteGC.Add(new Line("线段B"));
            compisiteGC.Add(new Circle("圆"));

            complexGraphics.Add(compisiteGC);
            Graphics c = new Line("线段C");
            complexGraphics.Add(c);

            //显示复杂图形
            Console.WriteLine("复杂图形的绘制如下：");
            Console.WriteLine("--------------------");
            complexGraphics.Draw();
            Console.WriteLine("--------------------");
            Console.WriteLine("复杂图形完成");

            //移除一个线段C
            complexGraphics.Remove(c);
            Console.WriteLine("复杂图形的绘制如下：");
            Console.WriteLine("--------------------");
            complexGraphics.Draw();
            Console.WriteLine("--------------------");
            Console.WriteLine("复杂图形完成");

            Console.ReadKey();

        }
        #endregion

        #region MethodTwo

        static void MethodTwo()
        {

            Console.WriteLine();
            AbstractFile file = new FileFolder("文件夹1");

            file.AddFile(new VideoFile("大话西游之月光宝盒.rmvb"));
            file.AddFile(new VideoFile("亮剑.rmvb"));
            file.AddFile(new ImageFile("月亮.jpg"));
            file.KillVirus();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();

            AbstractFile file2 = new FileFolder("文件夹2");
            file2.AddFile(new TextFile("春风十里.txt"));
            file2.AddFile(new ImageFile("冰红茶.jpg"));
            file2.AddFile(new VideoFile("战狼.rmvb"));
            file2.KillVirus();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();

            AbstractFile file3 = new ImageFile("绿城.jpg");
            file3.KillVirus();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();

            AbstractFile file4 = new TextFile("黄金时代.txt");
            file4.KillVirus();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();

            AbstractFile file5 = new VideoFile("中餐厅.rmvb");
            file5.KillVirus();
            Console.WriteLine("----------------------------------");

            Console.Read();

        }
        #endregion
    }
}
