using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarytest.Computer
{
    public class Queue
    {
        private int[] _container;
        private int count = 0;
        public Queue(int Size)
        {
            _container = new int[Size];
        }
        public int Count { get { return count; } }
        public void Enqueue(int a)
        {
            if (count < 10 && count >= 0)
            {
                for (int i = count; i > 0; i--)
                {
                    _container[i] = _container[i - 1];
                }
                _container[0] = a;
                count++;
            }
        }
        public int Dequque()
        {
            int ret = 0;
            if (count > 0)
            {
                ret = _container[count - 1];
                _container[count - 1] = 0;
                count--;
            }

            return ret;
        }

        public string DisplayAll()
        {
            int[] dest = new int[count];
            Array.Copy(_container, dest, count);
            string str = string.Join(",", dest);
            return str;
        }
    }
}
