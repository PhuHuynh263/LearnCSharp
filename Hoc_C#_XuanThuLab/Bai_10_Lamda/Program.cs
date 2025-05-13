using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_10_Lamda
{

    /*
     Lamda - Anoynmous function
        - Là một hàm không có tên
        - Có thể truyền vào như một tham số
    1) (tham số) => biểu thức
        (int a, int b) => a + b
    2) (tham số) => { câu lệnh }
        (int a, int b) => { return a + b; }

     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> thongBao;

            thongBao = (string s) => Console.WriteLine(s);

            thongBao?.Invoke("Hello World");
            //(int a, int b) => a + b;
            //(int a, int b) => { return a + b; };

        }
    }
}
