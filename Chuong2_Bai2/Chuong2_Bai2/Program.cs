using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong2_Bai2
{
    internal class Program
    {
        // Định nghĩa Enum cho cấp bậc nhân viên
        enum CapBacNhanVien
        {
            Intern = 1,  // Thực tập sinh
            Junior = 2,  // Nhân viên mới
            Mid = 3,     // Nhân viên có kinh nghiệm
            Senior = 4,  // Nhân viên cấp cao
            Lead = 5     // Trưởng nhóm
        }

        static void Main()
        {
            // Đặt UTF-8 để hiển thị tiếng Việt đúng
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // 1️⃣ In tất cả các cấp bậc và giá trị của Enum
            Console.WriteLine("Danh sách cấp bậc nhân viên:");
            foreach (CapBacNhanVien capBac in Enum.GetValues(typeof(CapBacNhanVien)))
            {
                Console.WriteLine($"{(int)capBac} - {capBac}");
            }

            // 2️⃣ Nhập số và tìm cấp bậc tương ứng
            Console.Write("\nNhập số cấp bậc (1-5): ");
            if (int.TryParse(Console.ReadLine(), out int soNhap_332))
            {
                if (Enum.IsDefined(typeof(CapBacNhanVien), soNhap_332))
                {
                    CapBacNhanVien capBacTimThay_332 = (CapBacNhanVien)soNhap_332;
                    Console.WriteLine($"Cấp bậc tương ứng: {capBacTimThay_332}");
                }
                else
                {
                    Console.WriteLine("Không có cấp bậc nào phù hợp!");
                }
            }
            else
            {
                Console.WriteLine("Vui lòng nhập một số hợp lệ!");
            }

            // 3️⃣ Nhập chuỗi và chuyển thành Enum
            Console.Write("\nNhập tên cấp bậc (Intern, Junior, Mid, Senior, Lead): ");
            string chuoiNhap_332 = Console.ReadLine();

            if (Enum.TryParse(chuoiNhap_332, true, out CapBacNhanVien capBacTuChuoi_332))
            {
                Console.WriteLine($"Chuỗi \"{chuoiNhap_332}\" tương ứng với cấp bậc: {capBacTuChuoi_332} ({(int)capBacTuChuoi_332})");
            }
            else
            {
                Console.WriteLine("Tên cấp bậc không hợp lệ!");
            }
            Console.ReadKey();
        }
    }
}
