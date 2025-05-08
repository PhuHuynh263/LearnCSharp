using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_17_vidu_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your n : ");
            int n = int.Parse(Console.ReadLine());
            Random rd = new Random();
            List<int> ds = new List<int>();
            for (int i = 0; i < n; i++)
            {
                ds.Add(rd.Next(1, 100));
            }
            Console.Write("Danh sách : ");
            foreach (var item in ds)
            {
                Console.Write(item + " ");
            }
        }
    }
}
