using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong2_Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Khai báo mảng tên sinh viên
            string[] sinhViens_332 = { "An", "Bình", "Cường", "Dương", "Hải" };

            // Duyệt mảng bằng foreach để in danh sách sinh viên
            Console.WriteLine("Danh sách sinh viên:");
            foreach (string ten_332 in sinhViens_332)
            {
                Console.WriteLine($"- {ten_332}");
            }
            Console.ReadKey();
        }
    }
}
