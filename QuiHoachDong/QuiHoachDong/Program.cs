using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiToanQuiHoachDong
{
    class Program
    {
        static void Main(string[] args)
        {
            string X = "ABCBDABSQ";
            string Y = "BDCABQ";
            int m = X.Length;
            int n = Y.Length;

            int[,] dp = new int[m + 1, n + 1];

            // Tính toán độ dài của chuỗi con chung dài nhất
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (X[i - 1] == Y[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            // Truy ngược lại để tìm chuỗi con chung dài nhất
            int index = dp[m, n];
            char[] lcs = new char[index];
            int k = m, l = n;

            while (k > 0 && l > 0)
            {
                if (X[k - 1] == Y[l - 1])
                {
                    lcs[index - 1] = X[k - 1];
                    k--;
                    l--;
                    index--;
                }
                else if (dp[k - 1, l] > dp[k, l - 1])
                {
                    k--;
                }
                else
                {
                    l--;
                }
            }

            // Hiển thị kết quả
            Console.WriteLine("Chuoi con chung dai nhat la: " + new string(lcs));
            Console.WriteLine("Do dai cua chuoi con chung dai nhat la: " + dp[m, n]);
            Console.ReadLine();
        }
    }
}