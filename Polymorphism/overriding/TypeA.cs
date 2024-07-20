using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.overriding
{
    public class TypeA
    {
        public int A { get; set; }
        public TypeA(int a)
        {
            A = a;
            Console.WriteLine("hello i am typeA ctor"); 
        }
        public void myFunction01()
        {
            Console.WriteLine("I am a base");
        }
        public virtual void myFunction02()
        {
            Console.WriteLine($"typeA is A: {A}");
        }
    
    }
}
