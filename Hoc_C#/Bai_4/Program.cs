using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            x = 5;
            y = 4;
            Console.WriteLine("X = " + x);

            /*  x += y;
              Console.WriteLine("X = " + x);*/

            x -= y;
            Console.WriteLine("X = " + x);
            Console.ReadKey();
        }
    }
}
