using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float diemTN;
            Console.Write("Moi ban nhap diem tot nghiep : ");
            diemTN = float.Parse(Console.ReadLine());

            if (diemTN > 7.0)
            {
                Console.WriteLine("Diem tot nghiep cua ban la {0} -> Ban da do!!!", diemTN);
            }
            else
            {
                Console.WriteLine("Diem tot nghiep cua ban la {0} -> Ban da tach!!!", diemTN);
            }

        }
    }
}
