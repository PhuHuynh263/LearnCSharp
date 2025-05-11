using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5_Generic
{
    internal class Program
    {
        static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        /*static void Swap(ref float x, ref float y)
                {
                    float temp = x;
                    x = y;
                    y = temp;
                }*/
        static void Main(string[] args)
        {
            int a = 5;
            int b = 45;

            Console.WriteLine($"So a = {a} So b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"So a = {a} So b = {b}");

            float x = 5;
            float y = 45;
            Console.WriteLine($"So x = {x} So y = {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"So x = {x} So y = {y}");
        }
    }
}
