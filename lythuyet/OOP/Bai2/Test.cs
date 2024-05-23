using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class Test
    {
        public void Swap(int a, int b)
        {
            int temp = a;
            a = b; b = temp;
            //Console.WriteLine(" a = " + a + " b = " + b) ;
        }

        public void Swap( ref int a , ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        
    }
}
