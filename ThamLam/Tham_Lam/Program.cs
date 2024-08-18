using System;
using System.Collections.Generic;
using System.Text;

class ChuongTrinh
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int soTien = 126; // Số tiền cần đổi
        int[] menhGia = { 100, 50, 20, 10, 5, 2, 1 }; // Các mệnh giá có sẵn

        List<int> ketQua = LaySoToTienToiThieu(soTien, menhGia);

        Console.WriteLine("Cần các tờ tiền mệnh giá sau để đổi " + soTien + " đồng:");
        foreach (int toTien in ketQua)
        {
            Console.WriteLine(toTien + " đồng");
            
        }
        Console.ReadKey();
    }

    static List<int> LaySoToTienToiThieu(int soTien, int[] menhGia)
    {
        List<int> ketQua = new List<int>();

        // Duyệt qua các mệnh giá từ lớn đến nhỏ
        foreach (int toTien in menhGia)
        {
            while (soTien >= toTien)
            {
                soTien -= toTien;
                ketQua.Add(toTien);
            }

        }


        return ketQua;
    }
}
