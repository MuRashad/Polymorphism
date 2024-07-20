using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Polymorphism.Binding
{
    public  class PartTimeEmp :Employee
    {
        public decimal HourRate { get; set; }
        public new void MyFunc01()
        {
            Console.WriteLine("I am part time employee");
        }
        public override void MyFunc02()
        {
            Console.WriteLine($"ID:{Id}, Name:{Name} ,Age:{Age},HourRate:{HourRate}");
        }
    }
}
