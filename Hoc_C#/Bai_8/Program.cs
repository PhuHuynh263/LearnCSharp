using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Please type n : ");
            n = int.Parse(Console.ReadLine());
            string answer = (n % 2 == 0) ? $"{n} is even" : $"{n} is odd";
            Console.WriteLine(answer);

        }
    }
}
