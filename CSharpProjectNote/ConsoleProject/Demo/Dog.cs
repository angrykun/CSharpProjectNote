using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Demo
{
    class Dog : Person
    {
        new public int ID { get; set; }
        new public string Name { get; set; }
        new public string Sex { get; set; }
        new protected string Say()
        {  
            base.Say();
            return "wang";
        }

    }
}
