using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c1 = ClassLibrarytest.Computer;
namespace Consoleapp
{
   class Program
    {           
        static void Main(string[] args)
        {    //THIS IS FOR CLASS1.cs(constructor)
           //ClassLibrarytest.Class1 c = new ClassLibrarytest.Class1(1,4,5);
            //  Console.WriteLine("the volume is:"+" "+ c.vol());


            //THIS REFER TO THE ARITHEMATIC.cs(get and set)
            //  ClassLibrarytest.math.Arithematic c = new ClassLibrarytest.math.Arithematic();
            //  c.dis();


            c1.CustomStack stack = new c1.CustomStack();
            Console.WriteLine($"Number of items : {stack.Count}, TotalItems : {stack.DisplayAll()}");

            stack.Push(1);
            Console.WriteLine($"Number of items : {stack.Count}, TotalItems : {stack.DisplayAll()}");
            stack.Push(10);
            Console.WriteLine($"Number of items : {stack.Count}, TotalItems : {stack.DisplayAll()}");
            stack.Push(14);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            Console.WriteLine($"Number of items : {stack.Count}, TotalItems : {stack.DisplayAll()}");
            stack.Pop();
            Console.WriteLine($"Number of items : {stack.Count}, TotalItems : {stack.DisplayAll()}");


            Console.ReadLine();
        }
    }


}
    

