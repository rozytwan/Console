using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrarytest.Inheritance;

namespace ClassLibrarytest.Inheritance
{
    public class Bus : Vehicals
    {

      public Bus(string Numberplate) : base()
        {
            this.id = 5;
            this.type = "Bus";
        }

    

        public void Size()
        {
            Console.WriteLine("Size is big");
           
        }

        public override void Run()
        {
            { Console.WriteLine($" { this.type} is running whose id is {this.id}"); }
       
         
        }
        public new void Stop()
        {
            Console.WriteLine("Running from Bus");
             base.Run();
        }
    }


}
