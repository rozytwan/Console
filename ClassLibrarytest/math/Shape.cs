using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarytest.math
{
    public abstract class Shape
    {
        public abstract void getinput();
        public abstract int area();



    }
    public class rectangle : Shape
    {
        int length = 0;
        int breadth = 0;
        public override int area()
        {
            return (length * breadth);
        }

        public override void getinput()
        {
            Console.WriteLine("Length");
            length = int.Parse(Console.ReadLine());
            Console.WriteLine("Breadth");
            breadth = int.Parse(Console.ReadLine());

        }



    }
    public class square : Shape
    {
        int length = 0;
        public override int area()
        {
            return (length ^ 2);
        }

        public override void getinput()
        {
            Console.WriteLine("Length");
            length = int.Parse(Console.ReadLine());
        }
    }
    public class circle : Shape
    {
        int radius = 0;
        const int  pi = 22/7;
        public override int area()
        {
            return (pi * (radius ^ 2));
        }

        public override void getinput()
        {
            Console.WriteLine("Radius");
            radius = int.Parse(Console.ReadLine());

        }
    }




}
