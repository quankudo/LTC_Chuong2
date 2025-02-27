using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong2_Bai5
{
    internal class Rectangle
    {
        public Point UpperLeft { get; set; }
        public Point BottomRight { get; set; }

        // Constructor nhận vào hai điểm
        public Rectangle(Point upperLeft, Point bottomRight)
        {
            UpperLeft = upperLeft;
            BottomRight = bottomRight;
        }

        // Hiển thị thông tin hình chữ nhật
        public void DisplayStatus()
        {
            Console.WriteLine("Rectangle:");
            Console.Write("  Upper Left: ");
            UpperLeft.DisplayStatus();
            Console.Write("  Bottom Right: ");
            BottomRight.DisplayStatus();
        }
    }
}
