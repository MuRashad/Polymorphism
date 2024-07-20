using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Binding
{
    public class FullTimeEmp :Employee
    {
        public decimal Salary { get; set; }


        public new void  MyFunc01()
        {
            Console.WriteLine("I am full time employee");
        }
        public override void MyFunc02()
        {
            Console.WriteLine($"ID:{Id}, Name:{Name} ,Age:{Age},salary:{Salary}");
        }
    }
}
