using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong2_Bai5
{
    enum PointColor
    {
        LightBlue,
        BloodRed,
        Gold
    }

    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointColor Color { get; set; }

        // Constructor mặc định (tọa độ 0, màu mặc định)
        public Point() : this(0, 0, PointColor.LightBlue) { }

        // Constructor có tham số x, y
        public Point(int x, int y) : this(x, y, PointColor.LightBlue) { }

        // Constructor đầy đủ (x, y, color)
        public Point(int x, int y, PointColor color)
        {
            X = x;
            Y = y;
            Color = color;
        }

        // Hiển thị thông tin điểm
        public void DisplayStatus()
        {
            Console.WriteLine($"Point({X}, {Y}) - Color: {Color}");
        }
    }
}
