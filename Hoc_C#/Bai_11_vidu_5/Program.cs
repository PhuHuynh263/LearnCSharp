using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_11_vidu_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n <= 1000; n++)
            {
                int total = 0;
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        total += i;
                    }
                }
                if (total == n)
                {
                    Console.WriteLine("{0} is perfect number", n);
                }
            }
        }
    }
}
