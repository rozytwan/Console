using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarytest
{
  
   public class Class1
    {
        int a, b, c;
        public Class1(int lr,int br,int hr)
           
        {
            this.a = lr;
            this.b = br;
            this.c = hr;
            Console.WriteLine("this is my new course for constructor");
            
        }
        public int vol()
        {
            return (this.a*this.b*this.c);
        }
     
    
    }
}

