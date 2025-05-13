using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_9_Delegate
{
    public delegate void ShowLog(string Message);

    internal class Program
    {
        static void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.ResetColor();
        }

        static void Warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ResetColor();
        }

        delegate int Kieu1();

        static int Tong(int a, int b)
        {
            return a + b;
        }
        static int Hieu(int a, int b)
        {
            return a - b;
        }

        static void Tong(int a, int b, ShowLog log)
        {
            int tong = a + b;
            log?.Invoke($"Tong {a} + {b} = {tong}");
        }

        static void Main(string[] args)
        {
            ShowLog log = null;
            //log = Info;
            //log("Hello World");
            //log.Invoke("Hello World ABC");

            //log = Warning;
            //log("Hello World");
            log += Info;
            log += Info;
            log += Info;
            log += Warning;
            log += Warning;
            log += Info;

            log?.Invoke("Hello World ABC");

            Console.WriteLine("Action");
            Action action;
            Action<string, int> action1;
            Action<string> action2;
            action2 = Warning;
            action2 += Info;
            action2("Hello World");

            Console.WriteLine("Func");
            Func<int> func;
            Func<string, double, string> func1;

            Func<int, int, int> tinhToan;
            tinhToan = Tong;
            Console.WriteLine(tinhToan(10, 20));
            tinhToan = Hieu;
            Console.WriteLine(tinhToan(10, 20));

            Tong(10, 20, Warning);
        }
    }
}
