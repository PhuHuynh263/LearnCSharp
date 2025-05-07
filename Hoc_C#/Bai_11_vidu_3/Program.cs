using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_11_vidu_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int total = 0;
            Console.Write("Enter a : ");
            a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                if (i % 2 != 0)
                {
                    if (i == 3)
                    {
                        continue;
                    }
                    Console.WriteLine("Odd is : " + i);
                    total += i;
                }
            }
            Console.Write("Odd total from 1 to {0} not include 3 is : {1} ", a, total);
        }
    }
}
