using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_11_vidu_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, a = 1;
            Console.Write("Enter n : ");
            n = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("{0}! = {1} ", n, factorial);

            //while (a <= n)
            //{
            //    factorial *= a;
            //    a++;
            //}
            //Console.WriteLine("{0}! = {1} ", n, factorial);
        }
    }
}
