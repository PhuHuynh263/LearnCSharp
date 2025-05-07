using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            float z = a / b;
            Console.WriteLine("Gia tri cua z la : {0}", z);

            float z2 = (float)a / b;
            Console.WriteLine("Gia tri cua z2 la : {0}", z2);

            byte x = 255;
            int y = x;
            int k = 400000;
            //byte l = k;
            byte l = (byte)k;
            Console.WriteLine("Gia tri cua l : " + l);
            Console.WriteLine("Gia tri cua k : " + k);
            Console.ReadKey();
        }
    }
}
