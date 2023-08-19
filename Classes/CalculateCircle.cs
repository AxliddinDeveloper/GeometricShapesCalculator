using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesCalculator.Classes
{
    public class CalculateCircle
    {
        public  void CalculateCirclee()
        {
            Console.WriteLine("Enter the radius of the circle:");
            double radius = double.Parse(Console.ReadLine());
            Console.Clear();
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("The area of the circle is: " + area);
            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine("The circumference of the circle is: " + perimeter);
            double diameter = 2 * radius;
            Console.WriteLine("The diameter of the circle is: " + diameter);
        }
    }
}
