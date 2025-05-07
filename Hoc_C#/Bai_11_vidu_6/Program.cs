using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_11_vidu_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Enter a : ");
            a = int.Parse(Console.ReadLine());
            while (a < 0)
            {
                Console.Write("a must to larger 0, Enter a again : ");
                a = int.Parse(Console.ReadLine());
            }
            int count = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.Write("{0} is a prime number", a);
            }
            else
            {
                Console.Write("{0} is not a prime number", a);
            }
        }
    }
}
