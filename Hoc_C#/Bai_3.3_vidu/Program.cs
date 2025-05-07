using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._3_vidu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i1 = 2;
            int i2 = 5;
            int i3 = -3;
            float d1 = 2.0f;
            float d2 = 5.0f;
            float d3 = -0.5f;

            Console.WriteLine($"a) {i1} + ({i2} * {i3}) = {i1 + (i2 * i3)}");
            Console.WriteLine($"b) {i1} * ({i2} + {i3}) = {i1 + (i2 + i3)}");
            Console.WriteLine($"c) {i1} / ({i2} + {i3}) = {i1 / (i2 + i3)}");
            Console.WriteLine($"e) {i1} / {i2} + {i3} = {(float)i1 / i2 + i3}");
            Console.WriteLine($"g) 3 + 4 + 5 / 3 = {3 + 4 + (float)5 / 3}");
            Console.WriteLine($"i) (3 + 4 + 5) / 3 = {(float)(3 + 4 + 5) / 3}");
            Console.WriteLine($"k) {d1} + ({d2} * {d3}) = {d1 + (d2 * d3)}");
            Console.WriteLine($"l) {d1} + {d2} * {d3} = {d1 + d2 * d3}");
            Console.WriteLine($"m) {d1} / {d2} - {d3} = {d1 / d2 - d3}");
            Console.WriteLine($"n) {d1} / ({d2} - {d3}) = {d1 / (d2 - d3)}");
            Console.WriteLine($"o) {d1} + {d2} + {d3} / 3 = {d1 + d2 + d3 / 3}");
            Console.WriteLine($"p) ({d1} + {d2} + {d3}) / 3 = {(d1 + d2 + d3) / 3}");
            Console.WriteLine($"q) {d1} + {d2} + ({d3} / 3) = {d1 + d2 + (d3 / 3)}");
            Console.WriteLine($"r) 3 * ({d1} + {d2}) + ({d1} - {d3}) = {3 * (d1 + d2) + (d1 - d3)}");
        }
    }
}
