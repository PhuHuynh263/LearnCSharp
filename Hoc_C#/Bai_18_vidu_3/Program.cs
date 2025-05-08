using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_18_vidu_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> quests = new List<string>() { "2 + 5 + 7 = ", "5 * 10 = ", "sprt(16) = ", "12 % 2 = ", "5 / 2 = " };
            List<int> answers = new List<int>() { 14, 50, 4, 0, 2 };
            for (int i = 0; i < quests.Count; i++)
            {
                Console.Write(quests[i]);
                int answer = int.Parse(Console.ReadLine());
                if (answer == answers[i])
                {
                    Console.WriteLine("Đúng");
                }
                else
                {
                    Console.WriteLine("Sai");
                }
            }
        }
    }
}
