using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_15._2_vidu_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  
              Cho:
              str1 = “English = 78 Science = 83 Math = 68 History = 65”
              1.tính tổng các số trong chuỗi trên
              2.tính trung bình cộng
            */


            string str1 = "English = 78 Science = 83 Math = 68 History = 65";
            string[] arr = str1.Split(' ');
            string strSo = "";
            foreach (string x in arr)
            {
                foreach (char c in x)
                {
                    if (char.IsDigit(c))
                    {
                        strSo += x + " ";
                        break;
                    }
                }
            }
            strSo = strSo.Trim();
            string[] arrSo = strSo.Split(' ');
            int tong = 0;
            int count = 0;
            foreach (string x in arrSo)
            {
                tong += int.Parse(x);
                count++;
            }
            Console.WriteLine("Tong cac so co trong chuoi : " + tong);
            Console.WriteLine("Trung binh cong : " + (double)tong / count);
        }
    }
}
