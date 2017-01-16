using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarytest.math
{
   public class Arithematic
    {

        int numb = 5;
        public void setnum(int num)
        {
            num = numb;
        }
        public int getnum()
        {
            return numb;
        }
        public void dis()
        {
            Console.WriteLine("THIS IS PROGRAM FOR IDEA OF GET AND SET IN C#" );
            Console.WriteLine("the required munber is "+ numb);
        }
    }
}