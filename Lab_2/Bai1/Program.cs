using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        /*
         * Coder by DucSunIT
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n, sum=0;
            Console.Write("Enter the value of n : ");
             n = int.Parse(Console.ReadLine());
            for(int i=2; i<=n; i += 2)
            {
                sum += i;
            }
            Console.WriteLine("Sum = {0}",sum);
            Console.ReadLine();
        }
    }
}
