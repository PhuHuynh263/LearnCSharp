using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_7_Null_Nullable
{
    class Abc
    {
        public void XinChao() => Console.WriteLine("Xin chao");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Abc a = new Abc();
            if (a != null)
                a.XinChao();
        }
    }
}
