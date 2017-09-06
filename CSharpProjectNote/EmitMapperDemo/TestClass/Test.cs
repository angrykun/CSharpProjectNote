using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmitMapperDemo.TestClass
{
    public class Test
    {
    }

    public class Source
    {
        public int A { get; set; }
        public decimal? B { get; set; }
        public string C { get; set; }
        public Inner D { get; set; }
        public string E { get; set; }
    }
    public class Dest
    {
        public int A { get; set; }
        public decimal? B { get; set; }
        public string C { get; set; }
        public Inner D { get; set; }
        public string F { get; set; }
    }
    public class Inner
    {
        public long D1 { get; set; }
        public Guid D2 { get; set; }
    }
}
