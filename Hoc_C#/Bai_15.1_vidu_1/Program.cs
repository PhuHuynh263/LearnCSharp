using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_15._1_vidu_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int demThuong = 0, demHoa = 0, demSo = 0, demSpace = 0;
            string chuoi = "Xin chào bạn tôi là Huỳnh Bá Đại Phú sinh ngày 26 tháng 3 năm 2002";
            char[] lst = chuoi.ToCharArray();
            foreach (char c in lst)
            {
                if (char.IsLower(c))
                {
                    demThuong++;
                }
                else if (char.IsUpper(c))
                {
                    demHoa++;
                }
                else if (char.IsDigit(c))
                {
                    demSo++;
                }
                else if (char.IsWhiteSpace(c))
                {
                    demSpace++;
                }
            }
            Console.WriteLine(chuoi);
            Console.WriteLine("Chữ thường : " + demThuong);
            Console.WriteLine("Chữ hoa : " + demHoa);
            Console.WriteLine("Số : " + demSo);
            Console.WriteLine("Khoảng trắng : " + demSpace);

        }
    }
}
