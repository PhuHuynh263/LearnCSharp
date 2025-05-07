using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_13_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime birthDay = new DateTime(2002, 3, 26);
            Console.WriteLine("My birhday : " + birthDay.ToString("dd/MM/yyyy"));

        }
    }
}
