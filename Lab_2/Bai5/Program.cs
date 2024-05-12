using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Program
    {
        /*
         * Coder by DucSunIT
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.Write("Enter the value of n : ");
            n = int.Parse(Console.ReadLine());
            long[] fibo = new long[101];
            fibo[0] = 0; // số fibo đầu tiên
            fibo[1] = 1; // số fibo thứ hai

            // tính các số fibo lưu vào mảng 
            for(int i=2; i<=92; i++)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
            }

            // in các số fibo
            for(int i=0; i< n; i++)
            {
                Console.Write(fibo[i] + " ");
            }
            Console.ReadLine();

        }
    }
}
