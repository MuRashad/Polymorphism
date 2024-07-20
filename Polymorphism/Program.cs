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
            //TypeA typeA = new TypeA(5);
            //typeA.A = 10;
            //typeA.myFunction01();
            //typeA.myFunction02();
            //Console.WriteLine("_+_+_+_+_+_+_+_+_+_+_+_+_+_");
            //TypeB typeB=new TypeB(5,10);
            //typeB.B = 25;
            //typeB.A = 15;
            //typeB.myFunction01();
            //typeB.myFunction02();
            #endregion

            #region Binding 
            //Dog is an animal , is animal a dog? NO 
            //cat is an animal , is animal a dog? NO   
            // lion is an animal , is animal a dog? NO 
            //if i have reference i can say =>all (Dog, Cat, Lion ) are animals so refAnimal=>(All)
            //Animal hatchi =new Dog() ;
            /*hatchi is an animal has all characteristic of animal
             * but he has override method got it from Dog , As well i can say he is an Animal override method from Dog
             *  
             */

            // 
            TypeA RefBase;
            //predicted=> i am point to Type A i can execute every thing in parent excepted virtual 
            //=>dynimically call the object from type(B) that inherit and override this method
            RefBase= new TypeB(5,3);
            // override by new =>(static binding)execute the parent method 
            RefBase.myFunction01();
            //override by keyword=>execute overrided child methode
            RefBase.myFunction02();


            #endregion
          
            #region not-binding
            /*when i make referrnce from child and point to parent as the same example above 
            *if animal is a dog as well if and only if Animal has a reference from Dog if not   
            *give me exception as not all animal is a dog so we call it casting =un safe casting
            */
            //TypeA typeA=new TypeB(5,3);

            //TypeB typeB=(TypeB)typeA;//casting not binding 
            #endregion



        }
    }
}
