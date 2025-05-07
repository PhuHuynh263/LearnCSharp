using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.ForegroundColor = ConsoleColor.Yellow;//Màu ký tự
            Console.WriteLine("Searching Program");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1. Search by name");
            Console.WriteLine("2. Search by author");
            Console.WriteLine("3. Search by manufacturer");
            Console.WriteLine("4. Search by title");
            Console.Write("Enter your choice : ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("1. Search by name");
                    break;
                case 2:
                    Console.WriteLine("2. Search by author");
                    break;
                case 3:
                    Console.WriteLine("3. Search by manufacturer");
                    break;
                case 4:
                    Console.WriteLine("4. Search by title");
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
