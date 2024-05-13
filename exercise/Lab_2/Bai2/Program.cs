using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
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
            double sum = 0;
            Console.Write("Enter the value of n = ");
            n = int.Parse(Console.ReadLine());
            for(int i=1; i<=n; i++)
            {
                sum += 1.0 / i;
            }
            Console.WriteLine("Sum = {0}", sum);
            Console.ReadLine();
        }
    }
}
