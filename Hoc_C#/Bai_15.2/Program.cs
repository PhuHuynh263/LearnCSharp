using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_15._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14. IndexOf
            string chuoi20 = "Xin chao cac ban";
            int viTri = chuoi20.IndexOf("chao");
            Console.WriteLine("Vi tri cua chuoi 'chao' trong chuoi 20 la: " + viTri);

            //15. LastIndexOf
            string chuoi21 = "Xin chao cac ban, chao cac ban";
            int viTriCuoi = chuoi21.LastIndexOf("chao");
            Console.WriteLine("Vi tri cuoi cua chuoi 'chao' trong chuoi 21 la: " + viTriCuoi);

            //16. Remove
            string chuoi22 = "Xin chao cac ban";
            string chuoiXoa = chuoi22.Remove(3, 4);
            Console.WriteLine(chuoiXoa);

            //17. Replace
            string chuoi23 = "Xin chao cac ban";
            string chuoiThayThe = chuoi23.Replace("chao", "hello");
            Console.WriteLine(chuoiThayThe);

            //18. bool startsWith
            string chuoi24 = "Xin chao cac ban";
            bool batDau = chuoi24.StartsWith("Xin");
            Console.WriteLine("Chuoi 24 bat dau bang 'Xin': " + batDau);

            //19. Substring
            string chuoi25 = "Xin chao cac ban";
            string chuoiCon = chuoi25.Substring(4, 4);
            Console.WriteLine("Chuoi con cua chuoi 25 la: " + chuoiCon);

            //20. ToLower
            string chuoi26 = "Xin chao cac ban";
            string chuoiNho = chuoi26.ToLower();
            Console.WriteLine(chuoiNho);

            //21. ToUpper
            string chuoi27 = "Xin chao cac ban";
            string chuoiLon = chuoi27.ToUpper();
            Console.WriteLine(chuoiLon);

            //22. Trim
            string chuoi28 = "   Xin chao cac ban   ";
            string chuoiTrim = chuoi28.Trim();
            Console.WriteLine(chuoiTrim);

            //23. TrimStart
            string chuoi29 = "   Xin chao cac ban   ";
            string chuoiTrimStart = chuoi29.TrimStart();
            Console.WriteLine(chuoiTrimStart);

            //24. TrimEnd
            string chuoi30 = "   Xin chao cac ban   ";
            string chuoiTrimEnd = chuoi30.TrimEnd();
            Console.WriteLine(chuoiTrimEnd);

            //25. split
            string chuoi31 = "Xin chao cac ban";
            string[] mangChuoi = chuoi31.Split(' ');
            Console.WriteLine("Cac phan tu trong mang chuoi la: ");
            foreach (string item in mangChuoi)
            {
                Console.WriteLine(item);
            }

            //26. Join
            string[] mangChuoi2 = { "Xin", "chao", "cac", "ban" };
            string chuoi32 = string.Join(" ", mangChuoi2);
            Console.WriteLine("Chuoi sau khi join la: " + chuoi32);

        }
    }
}
