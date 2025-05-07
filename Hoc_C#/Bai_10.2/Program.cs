using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int tong = 0;
            do
            {
                tong += n;
                n++;
            } while (n <= 5);
            Console.WriteLine("Sum from 1 to 5 : " + tong);
        }
    }
}
