using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C1 = ClassLibrarytest.Computer;
namespace Consoleapp
{
   class Program
    {           
        static void Main(string[] args)
        {    //THIS IS FOR CLASS1.cs(constructor)
           ClassLibrarytest.Class1 c = new ClassLibrarytest.Class1(1,4,5);
          //  Console.WriteLine("the volume is:"+" "+ c.vol());


            //THIS REFER TO THE ARITHEMATIC.cs(get and set)
         //  ClassLibrarytest.math.Arithematic c = new ClassLibrarytest.math.Arithematic();
            //  c.dis();
            C1.Stack r = new C1.Stack();
            Console.WriteLine("number of item"+ r.Display());
            Console.ReadLine();


        }
    }
}
