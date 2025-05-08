using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //2.Khởi tạo list
            List<string> ds1 = new List<string>();
            List<int> ds2 = new List<int>();
            //3.Khởi tạo có sẵn các phần tử
            List<string> ds3 = new List<string>() { "Hà Nội", "Đà Nẵng", "Hồ Chí Minh" };
            foreach (var item in ds3)
            {
                Console.WriteLine(item + " ");
            }

            //4. Add phần tử vào list
            List<int> ds4 = new List<int>() { 1, 2, 5 };
            ds4.Add(3);
            Console.Write("Danh sách 4 : ");
            foreach (var item in ds4)
            {
                Console.Write(item + " ");
            }

            //5. Remove phần tử trong list
            List<int> ds5 = new List<int>() { 1, 2, 3, 4, 5 };
            ds5.Remove(3);
            Console.Write("\nDanh sách 5 : ");
            foreach (var item in ds5)
            {
                Console.Write(item + " ");
            }

            //6.Count số phần tử trong list
            List<int> ds6 = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine("\nSố phần tử trong danh sách 6 : " + ds6.Count);

            //7. Clear xóa toàn bộ phần tử trong list
            List<int> ds7 = new List<int>() { 1, 2, 3, 4, 5 };
            ds7.Clear();
            Console.Write("\nDanh sách 7 : ");
            foreach (var item in ds7)
            {
                Console.Write(item + " ");
            }

            //8. AddRange thêm nhiều phần tử vào list
            List<int> ds8 = new List<int>() { 1, 2, 3 };
            List<int> ds9 = new List<int>() { 4, 5, 6 };
            ds8.AddRange(ds9);
            Console.Write("\nDanh sách 8 : ");
            foreach (var item in ds8)
            {
                Console.Write(item + " ");
            }

            //9.boolean Contains kiểm tra phần tử có trong list hay không
            List<int> ds10 = new List<int>() { 1, 2, 3, 4, 5 };
            if (ds10.Contains(3))
            {
                Console.WriteLine("\nDanh sách 10 có phần tử 3");
            }
            else
            {
                Console.WriteLine("\nDanh sách 10 không có phần tử 3");
            }

            //10. GetRange lấy một khoảng phần tử trong list
            List<int> ds11 = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> ds12 = ds11.GetRange(1, 3);
            Console.Write("\nDanh sách 12 : ");
            foreach (var item in ds12)
            {
                Console.Write(item + " ");
            }

            //11. indexOf tìm vị trí của phần tử trong list
            List<int> ds13 = new List<int>() { 1, 2, 3, 4, 5 };
            int index = ds13.IndexOf(3);
            if (index != -1)
            {
                Console.WriteLine("\nPhần tử 3 nằm ở vị trí " + index);
            }
            else
            {
                Console.WriteLine("\nKhông tìm thấy phần tử 3");
            }

            //12. Insert thêm phần tử vào vị trí chỉ định
            List<int> ds14 = new List<int>() { 1, 2, 3, 4, 5 };
            ds14.Insert(2, 10);
            Console.Write("\nDanh sách 14 : ");
            foreach (var item in ds14)
            {
                Console.Write(item + " ");
            }

            //13. InsertRange thêm nhiều phần tử vào vị trí chỉ định
            List<int> ds15 = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> ds16 = new List<int>() { 6, 7, 8 };
            ds15.InsertRange(2, ds16);
            Console.Write("\nDanh sách 16 : ");
            foreach (var item in ds15)
            {
                Console.Write(item + " ");
            }

            //14. RemoveAt xóa phần tử tại vị trí chỉ định
            List<int> ds17 = new List<int>() { 1, 2, 3, 4, 5 };
            ds17.RemoveAt(2);
            Console.Write("\nDanh sách 17 : ");
            foreach (var item in ds17)
            {
                Console.Write(item + " ");
            }
            //15. RemoveRange xóa nhiều phần tử tại vị trí chỉ định
            List<int> ds18 = new List<int>() { 1, 2, 3, 4, 5 };
            ds18.RemoveRange(2, 2);
            Console.Write("\nDanh sách 18 : ");
            foreach (var item in ds18)
            {
                Console.Write(item + " ");
            }
            //16. Reverse đảo ngược thứ tự phần tử trong list
            List<int> ds19 = new List<int>() { 1, 2, 3, 4, 5 };
            ds19.Reverse();
            Console.Write("\nDanh sách 19 : ");
            foreach (var item in ds19)
            {
                Console.Write(item + " ");
            }
            //17. Sort sắp xếp thứ tự phần tử trong list
            List<int> ds20 = new List<int>() { 5, 4, 3, 2, 1 };
            ds20.Sort();
            Console.Write("\nDanh sách 20 : ");
            foreach (var item in ds20)
            {
                Console.Write(item + " ");
            }
            //18. BinarySearch tìm kiếm nhị phân
            List<int> ds21 = new List<int>() { 1, 2, 3, 4, 5 };
            int index1 = ds21.BinarySearch(3);
            if (index1 != -1)
            {
                Console.WriteLine("\nPhần tử 3 nằm ở vị trí " + index1);
            }
            else
            {
                Console.WriteLine("\nKhông tìm thấy phần tử 3");
            }

            //19. Max, min
            List<int> ds22 = new List<int>() { 1, 2, 3, 4, 5 };
            int max = ds22.Max();
            int min = ds22.Min();
            Console.WriteLine("\nPhần tử lớn nhất là " + max);
            Console.WriteLine("Phần tử nhỏ nhất là " + min);



        }
    }
}
