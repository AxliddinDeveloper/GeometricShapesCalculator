using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesCalculator.Classes
{
    public  class CalculateRectangle
    {
        public void CalculateRectanglee()
        {
            Console.WriteLine("Enter the length of the rectangle:");
            double length = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Enter the width of the rectangle:");
            double width = double.Parse(Console.ReadLine());
            Console.Clear();
            double area = length * width;
            Console.WriteLine("The area of the rectangle is: " + area);

            double perimeter = 2 * (length + width);
            Console.WriteLine("The perimeter of the rectangle is: " + perimeter);

            double side = Math.Sqrt(Math.Pow(length, 2) + Math.Pow(width, 2));
            Console.WriteLine("The diagonal length of the rectangle is: " + side);
        }
    }
}