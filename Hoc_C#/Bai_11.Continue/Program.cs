using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_11.Continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tong = 0;
            for (int i = 0; i <= 5; i++)
            {
                if (i == 3)
                    continue;
                else
                {
                    Console.WriteLine("i = " + i);
                    tong += i;
                    Console.WriteLine("tong = " + tong);
                }
            }
        }
    }
}
