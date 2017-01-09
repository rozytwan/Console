using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarytest.Computer
{
  public  class Stack
    {
        public int[] _container = new int[10];
        private int count = 0;
        public int Count { get { return count;
                    } }
        public void push(int a)
        {
            if (count < 10)
            {


                _container[count] = a;
                count++;
            }

        }
        public int pop()
        {
            int ret = 0;
            if (count>=0)
            {
                ret = _container[count];
                _container[count] = 0;
                count--;
            }
            return ret;
        }
        public string Display()
        {
            int[] dest = new int[count - 1];
                Array.Copy(_container, dest,count);
            string str = string.Join(",",dest);
            return str;
        }

    }
}