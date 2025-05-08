using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_19_vidu_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Dictionary<string, int> dic = new Dictionary<string, int>(){ {"A",1},{"B",2},{ "C",3},{ "D",2},{ "E",1},{ "F",4},{ "G",2},{ "H",4},{ "I",1},{ "J",8},{ "K",5},{ "L",1},{ "M",3},{ "N",1},{ "O",1},{ "P",3},
            { "Q",10},{ "R",1},{ "S",1},{ "T",1},{ "U",1},{ "V",4},{ "W",4},{ "X",8},{ "Y",4},{ "Z",10} };
            1: Tách số và chữ , hiển thị lên màn hình	
            2: tính tổng các số
            3: chuyển đổi chuỗi : "University of Technology and Education" sang số
             */
            Console.OutputEncoding = Encoding.UTF8;
            Dictionary<string, int> dic = new Dictionary<string, int>()
            {
                {"A",1},{"B",2},{"C",3},{"D",2},{"E",1},{"F",4},{"G",2},{"H",4},{"I",1},
                {"J",8},{"K",5},{"L",1},{"M",3},{"N",1},{"O",1},{"P",3},{"Q",10},
                {"R",1},{"S",1},{"T",1},{"U",1},{"V",4},{"W",4},{"X",8},{"Y",4},
                {"Z",10}
            };
            List<string> letters = new List<string>();
            List<int> numbers = new List<int>();
            letters = dic.Keys.ToList();
            numbers = dic.Values.ToList();
            Console.WriteLine("Các chữ cái trong dictionary:");
            foreach (string item in letters)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Các số trong dictionary:");
            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
            int tong = 0;
            foreach (int item in numbers)
            {
                tong += item;
            }
            Console.WriteLine();
            Console.WriteLine("Tổng các số trong dictionary: " + tong);
            string s1 = "University of Technology and Education";
            string s2 = "";
            foreach (char c in s1)
            {
                s2 += char.ToUpper(c);
            }
            Console.WriteLine("Chuỗi viết hoa : " + s2);
            string sChuyenDoi = "";
            foreach (char c in s2)
            {
                if (c == ' ')
                {
                    sChuyenDoi += " ";
                }
                else
                {
                    sChuyenDoi += dic[c.ToString()];
                }
            }
            Console.WriteLine("Chuỗi chuyển đổi : " + sChuyenDoi);
        }
    }
}
