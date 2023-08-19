using System;
using System.Collections;
using GeometricShapesCalculator.Classes;

namespace GeometricShapesCalculator
{
    class Program
    {
        
        
        public static void Main()
        {
            CalculateCircle circle = new CalculateCircle();
            CalculateRectangle rectangle = new CalculateRectangle();
            CalculateTriangle triangle = new CalculateTriangle();
            Console.WriteLine("Welcome to the Shape Calculator!");
            Console.WriteLine("Which shape would you like to calculate?");
            Console.WriteLine("1. Triangle");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Circle");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    triangle.CalculateTrianglee();
                    break;
                case 2:
                    rectangle.CalculateRectanglee();
                    break;
                case 3:
                    circle.CalculateCirclee();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
            Console.ReadLine();
        }
    }
}