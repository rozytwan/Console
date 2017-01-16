using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrarytest.Inheritance;

namespace ClassLibrarytest.Inheritance
{
   public class Vehicals
    {
        public string numberplate;
        public string Numberplate
        {
            get { return numberplate; }
        }
        public string name;
        public string Name
        {
            get { return name; }
          //  set { name = value; }


        }

        protected int id = 0;
        protected string type;
        public Vehicals(string Numberplate)//constructor wit parameter
        { numberplate = Numberplate; }

        public Vehicals()//constructor witnon parameter
        {
            numberplate = "";
        }

     
        public virtual void Run()
        { Console.WriteLine($" { this.type} is running whose id is {this.id}"); }
        public void Stop()
        { Console.WriteLine("vehical is stoped"); }

    }
}