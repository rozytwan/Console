using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using c1 = ClassLibrarytest.Computer;
using ClassLibrarytest.Inheritance;
namespace ClassLibrarytest.Inheritance

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


        /*    c1.CustomStack stack = new c1.CustomStack();

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
      Console.WriteLine($"Number of items : {stack.Count}, TotalItems : {stack.DisplayAll()}");*/



        ////testing with generic stack
        /*  c1.GenericStack<int> s1 = new c1.GenericStack<int>();



            c1.GenericStack<string> s2  = new c1.GenericStack<string>();
            Console.WriteLine($"Number of items : {s2.Count}, TotalItems : {s2.DisplayAll()}");

            s2.Push("a");
            Console.WriteLine($"Number of items : {s2.Count}, TotalItems : {s2.DisplayAll()}");
            s2.Push("b");
            Console.WriteLine($"Number of items : {s2.Count}, TotalItems : {s2.DisplayAll()}");
            s2.Push("c");
            s2.Push("d");
            s2.Push("e");
            s2.Push("f");
            Console.WriteLine($"Number of items : {s2.Count}, TotalItems : {s2.DisplayAll()}");
            s2.Pop();
            Console.WriteLine($"Number of items : {s2.Count}, TotalItems : {s2.DisplayAll()}");

            c1.GenericStack<c1.Student> s3  = new c1.GenericStack<c1.Student>();
            Console.WriteLine($"Number of items : {s3.Count}, TotalItems : {s3.DisplayAll()}");

            s3.Push(new c1.Student() {  Id=1, Name="a", Roll="a1"});
            Console.WriteLine($"Number of items : {s3.Count}, TotalItems : {s3.DisplayAll()}");
            s3.Push(new c1.Student() { Id = 2, Name = "b", Roll = "b2" });
            Console.WriteLine($"Number of items : {s3.Count}, TotalItems : {s3.DisplayAll()}");
            s3.Push(new c1.Student() { Id = 3, Name = "c", Roll = "c3" });
             s3.Push(new c1.Student() { Id = 4, Name = "d", Roll = "d4" });
          s3.Push(new c1.Student() { Id = 5, Name = "e", Roll = "e5" });
          s3.Push(new c1.Student() { Id = 6, Name = "f", Roll = "f6" });
          Console.WriteLine($"Number of items : {s3.Count}, TotalItems : {s3.DisplayAll()}");
            s3.Pop();
            Console.WriteLine($"Number of items : {s3.Count}, TotalItems : {s3.DisplayAll()}");*/



        /*  c1.Queue s1 = new ClassLibrarytest.Computer.Queue();
          Console.WriteLine($"Number of items : {s1.Count}, TotalItems : {s1.DisplayAll()}");

          s1.Enqueue(1);
          Console.WriteLine($"Number of items : {s1.Count}, TotalItems : {s1.DisplayAll()}");
          s1.Enqueue(10);
          Console.WriteLine($"Number of items : {s1.Count}, TotalItems : {s1.DisplayAll()}");
          s1.Enqueue(14);
          s1.Enqueue(3);
          s1.Enqueue(2);
          s1.Enqueue(1);
          Console.WriteLine($"Number of items : {s1.Count}, TotalItems : {s1.DisplayAll()}");
          s1.Dequque();
          Console.WriteLine($"Number of items : {s1.Count}, TotalItems : {s1.DisplayAll()}");*/

        //Inheritance implementation
        Vehicals v = new Vehicals();
        Bus b = new Bus("");
        v.Run();

        b.Run();
        v.Stop();
        b.Stop();

        //Abstract(Factory method)
        /*   Shape s;
           Console.WriteLine("choose option 1.rectangle /n2.square /n3.circle ");
           int choose = int.Parse(Console.ReadLine());
           switch (choose)
           {
               case 1:
                   s = new rectangle();
                   break;
               case 2:
                   s = new square();
                   break;
               case 3:
                   s = new circle();
                   break;

               default:
                   s = new rectangle();
                   break;
           }
           s.getinput();

           Console.WriteLine("the area int choose is "s.area());

    */
    

        Console.ReadLine();
       }
    
    }
}

    

