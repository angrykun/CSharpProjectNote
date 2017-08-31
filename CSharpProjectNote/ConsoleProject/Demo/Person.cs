using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Demo
{
    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Job { get; set; }

        protected string Say()
        {
            return "Hello ";
        }
    }
}
