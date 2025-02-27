using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong2_Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Tạo và hiển thị thông tin điểm
            Point p1_332 = new Point(3, 5, PointColor.Gold);
            Point p2_332 = new Point(8, 2, PointColor.BloodRed);

            Console.WriteLine("Displaying Points:");
            p1_332.DisplayStatus();
            p2_332.DisplayStatus();

            // Tạo hình chữ nhật với 2 điểm
            Rectangle rect_332 = new Rectangle(p1_332, p2_332);

            // Hiển thị thông tin hình chữ nhật
            Console.WriteLine("\nDisplaying Rectangle:");
            rect_332.DisplayStatus();
            Console.ReadKey();
        }
    }
}
