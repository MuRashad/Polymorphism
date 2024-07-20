using Polymorphism.overriding;

namespace Polymorphism
{
    internal class Program
    {
        #region overloading-Methods
        //the same (name- return type) but different in the number of parameter
        //this example like Writeline()=>function can take differnt many type but same action as read data and print it in console; 
       //public static int Sum(int x,int y){ return x + y; }
       //public static int Sum(int x,int y,int z){ return x + y + z; }
       //public static int Sum(int x,int y,int z,int s){ return x + y + z + s; }
        #endregion

        static void Main(string[] args)
        {

            #region print overloading-methods
            //Console.WriteLine(Sum(10, 10));
            //Console.WriteLine(Sum(10, 10, 15));
            //Console.WriteLine(Sum(10, 10, 20));
            //Console.WriteLine(Sum(10, 10, 20, 30)); 
            #endregion

            #region overriding
            TypeA typeA = new TypeA(5);
            typeA.A = 10;
            typeA.myFunction01();
            typeA.myFunction02();
            Console.WriteLine("_+_+_+_+_+_+_+_+_+_+_+_+_+_");
            TypeB typeB=new TypeB(5,10);
            typeB.B = 25;
            typeB.A = 15;
            typeB.myFunction01();
            typeB.myFunction02();
            #endregion
        }
    }
}
