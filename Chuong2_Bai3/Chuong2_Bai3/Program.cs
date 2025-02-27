using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong2_Bai3
{
    enum CapBacNhanVien
    {
        Intern = 1,
        Junior = 2,
        Mid = 3,
        Senior = 4,
        Lead = 5
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                // Khởi tạo nhân viên
                NhanVien nv1_332 = new NhanVien("Nguyễn Văn A", CapBacNhanVien.Mid, 2000);
                NhanVien nv2_332 = new NhanVien("Trần Thị B", CapBacNhanVien.Senior, 4000);

                // Hiển thị thông tin
                nv1_332.HienThiThongTin();
                nv2_332.HienThiThongTin();

                // Tính lương với hệ số thưởng mặc định
                Console.WriteLine($"Lương của {nv1_332.Ten}: {nv1_332.TinhLuong()} USD");

                // Tính lương với hệ số thưởng tùy chỉnh
                Console.WriteLine($"Lương của {nv2_332.Ten} (hệ số thưởng 1.2): {nv2_332.TinhLuong(1.2)} USD");
                Console.ReadKey();
            }
        }
    }
}
