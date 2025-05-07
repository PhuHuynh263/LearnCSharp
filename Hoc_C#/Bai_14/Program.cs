using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch1 = 'a';
            Console.WriteLine(ch1);
            Console.WriteLine(ch1.GetType().ToString());

            char ch2 = (char)64;
            Console.WriteLine(ch2);
            Console.WriteLine(ch2.GetType().ToString());

            //Ép kiểu char dữ liệu nhập vào
            char ch3 = char.Parse("b");
            Console.WriteLine(ch3);
            Console.WriteLine(ch3.GetType().ToString());

            //Chuyển đổi dữ liệu
            char ch4 = Convert.ToChar("t");
            Console.WriteLine(ch4);
            Console.WriteLine(ch4.GetType().ToString());

            //So sánh 2 ký tự
            char ch7 = 'a'; //97
            char ch8 = 'b'; //98
            char ch9 = 'a'; //97
            char ch10 = 'm'; //109
            Console.WriteLine(ch7.CompareTo(ch8));
            Console.WriteLine(ch8.CompareTo(ch7));
            Console.WriteLine(ch7.CompareTo(ch9));
            Console.WriteLine(ch7.CompareTo(ch10));

            Console.WriteLine(ch7.Equals(ch8));
            Console.WriteLine(ch7.Equals(ch9));


        }
    }
}
