using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tong = 0;
            for (int i = 0; i <= 10; i += 2)
            {
                tong += i;
                Console.WriteLine("i = " + i);
                Console.WriteLine("Tong = " + tong);
            }
        }
    }
}
