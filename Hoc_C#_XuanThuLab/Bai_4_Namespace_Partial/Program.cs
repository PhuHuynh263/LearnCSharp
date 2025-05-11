using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;

namespace Bai_4_Namespace_Partial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyNameSpace.Class1.XinChao();
            MyNameSpace.Abc.Class1.XinChao();
            WriteLine(PI);
            WriteLine(Sin(PI / 4));

            SanPham.Product product = new SanPham.Product();
            product.Name = "Test";
            product.Price = 1000;
            product.description = "Day la iPad";
            WriteLine(product.GetInfo());

        }
    }
}
