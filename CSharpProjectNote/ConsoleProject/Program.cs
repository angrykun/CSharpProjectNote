using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test());
            new Point().PointX();
            Console.ReadKey();
        }

        struct Point
        {
            private int x;
            private int y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public void PointX()
            {
                Console.WriteLine(this.x);
            }
        }
        static string Test()
        {
            try
            {
                throw new Exception("chucuo");
            }
            catch
            {
                return "catch";
            }
            finally
            {
                Console.WriteLine("finally");

            }
        }
    }
}
