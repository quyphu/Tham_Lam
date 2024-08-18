using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiaDeTri
{
    class Program
    {
        static void Main()
        {
            // Giả sử danh sách mã số sản phẩm được sắp xếp tăng dần
            int[] productCodes = { 10000, 10050, 10100, 10123, 10200, 10300, 15000, 20000 };

            // Yêu cầu người dùng nhập mã sản phẩm cần tìm
            Console.Write("Nhập mã số sản phẩm cần tìm: ");
            int targetCode;
            while (!int.TryParse(Console.ReadLine(), out targetCode))
            {
                Console.WriteLine("Mã số sản phẩm không hợp lệ, vui lòng nhập lại:");
            }

            // Gọi hàm tìm kiếm nhị phân
            int result = BinarySearch(productCodes, targetCode);

            // Kiểm tra kết quả
            if (result != -1)
            {
                Console.WriteLine("Sản phẩm có mã số {0} được tìm thấy tại vị trí thứ {1}.", targetCode, result + 1);
            }
            else
            {
                Console.WriteLine("Sản phẩm có mã số {0} không tồn tại trong kho.", targetCode);
            }

            // Chờ người dùng nhấn phím để đóng cửa sổ console
            Console.WriteLine("Nhấn phím Enter để thoát...");
            Console.ReadLine();
        }

        // Hàm tìm kiếm nhị phân
        static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Kiểm tra nếu phần tử giữa là phần tử cần tìm
                if (array[mid] == target)
                    return mid;

                // Nếu phần tử cần tìm nhỏ hơn phần tử giữa, tìm trong nửa bên trái
                if (array[mid] > target)
                    right = mid - 1;
                // Nếu phần tử cần tìm lớn hơn phần tử giữa, tìm trong nửa bên phải
                else
                    left = mid + 1;
            }

            // Trả về -1 nếu không tìm thấy phần tử
            return -1;
        }
    }
}
