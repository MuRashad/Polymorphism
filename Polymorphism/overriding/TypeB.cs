using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.overriding
{
    public class TypeB :TypeA
    {
        public int B { get; set; }
        //i have no parameter less ctor , as well i have to follow default chain parmaterless constructor parent if i don't have 
        //i have to commite with parameteize ctor for parent then ctor for children
        public TypeB(int _A ,int _B):base(_A)
        {
            B = _B;
            Console.WriteLine("hello i am typeB ctor");
        }
        //new=>i can override by new , this is the fist method to override from parent
        public new void myFunction01()
        {
            Console.WriteLine("I am a child");
        }
        //override=>i can override by override word, this is the 2nd method to override from parent but must parent to have virtual
        public override void myFunction02()
        {
            Console.WriteLine($"typeA is B: {B}");
        }
      

    }
}
