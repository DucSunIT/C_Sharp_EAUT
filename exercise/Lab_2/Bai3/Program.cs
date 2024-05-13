using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
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
            bool check = true;
            Console.Write("Nhập n = ");
            n = int.Parse(Console.ReadLine());
            if (n < 2)
            {
                check = false;
            }
            for(int i=2; i<=Math.Sqrt(n); i++)
            {
                if (n % i == 0) check = false;
                
            }
            if (check) Console.WriteLine(n + " là số nguyên tố !");
            else Console.WriteLine(n + " không là số nguyên tố !");
            Console.ReadLine();
        }
    }
}
