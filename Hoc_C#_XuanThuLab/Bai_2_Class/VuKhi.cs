using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2_Class
{
    class VuKhi
    {
        public string name = "Tên vũ khí";
        int doSatThuong = 10;
        public int SatThuong
        {
            set
            {
                Console.WriteLine(value);
            }
            get { return 10; }
        }
        public VuKhi()
        {
            Console.WriteLine("Khởi tạo");
        }
        public VuKhi(string name, int _doSatThuong)
        {
            doSatThuong = _doSatThuong;
            this.name = name;
        }
        //Phương thức
        public void ThietLapDoSatThuong(int doSatThuong)
        {
            this.doSatThuong = doSatThuong;
        }
        public void TanCong()
        {
            Console.WriteLine(name);
            for (int i = 0; i < doSatThuong; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        //Thuộc tính

    }
}
