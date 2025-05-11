using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    internal class Program
    {
        class Product<A>
        {
            A ID;
            public void SetID(A _id)
            {
                this.ID = _id;
            }

            public void PrintInf()
            {
                Console.WriteLine($"ID = {this.ID}");
            }
        }
        static void Main(string[] args)
        {
            Product<int> samPham1 = new Product<int>();
            samPham1.SetID(1);
            samPham1.PrintInf();

            Product<string> samPham2 = new Product<string>();
            samPham2.SetID("abc");
            samPham2.PrintInf();
        }
    }
}
