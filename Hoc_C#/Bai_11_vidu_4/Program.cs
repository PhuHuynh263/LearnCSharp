using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_11_vidu_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fac = 1;
            int tong = 0;
            for (int i = 1; i <= 10; i++)
            {
                fac *= i;
                tong += fac;
            }
            Console.Write("S = 1! + 2! + 3! +....+ 10! = " + tong);
        }
    }
}
