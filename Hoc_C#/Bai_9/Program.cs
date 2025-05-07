using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Type a : ");
            a = int.Parse(Console.ReadLine());
            int div = a % 2;
            switch (div)
            {
                case 0:
                    Console.WriteLine("{0} is even", a);
                    break;
                default:
                    Console.WriteLine("{0} is odd", a);
                    break;
            }
        }
    }
}
