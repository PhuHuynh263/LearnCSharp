using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_11_vidu_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int total = 0;
            Console.Write("Enter a : ");
            a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                for (int i = 0; i < a; i += 2)
                {
                    total += i;
                }
                Console.WriteLine("Even total from 0 to {0} is {1}.", a, total);
            }
            else
            {
                Console.WriteLine("Because {0} is odd number, " +
                    "i dont sum odd number, bye bye!!!", a);

            }
        }
    }
}
