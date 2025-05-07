using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._2_vidu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hoTen;
            float diemToan, diemVan;
            Console.Write("Moi nhap vao ho ten : ");
            hoTen = Console.ReadLine();

            Console.Write("Moi nhap vao diem Toan : ");
            diemToan = float.Parse(Console.ReadLine());

            Console.Write("Moi nhap vao diem Van : ");
            diemVan = float.Parse(Console.ReadLine());

            Console.WriteLine($"Hoc sinh {hoTen} co diem toan : {diemToan} va diem van : {diemVan}");
        }
    }
}
