using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesCalculator.Classes
{
    public class CalculateTriangle
    {
        public void CalculateTrianglee()
        {
            Console.WriteLine("Enter the base length of the triangle:");
            double baseLength = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Enter the height of the triangle:");
            double height = 
            double.Parse(Console.ReadLine());
            Console.Clear();
            double area = (baseLength * height) / 2;
            Console.WriteLine("The area of the triangle is: " + area);

            double perimeter = baseLength + 2 * (Math.Sqrt(Math.Pow(baseLength / 2, 2) + Math.Pow(height, 2)));
            Console.WriteLine("The perimeter of the triangle is: " + perimeter);

            double side = baseLength;
            Console.WriteLine("The side length of the triangle is: " + side);
        }
    }
}