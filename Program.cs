using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Shape Calculator!");
        Console.WriteLine("Which shape would you like to calculate?");
        Console.WriteLine("1. Triangle");
        Console.WriteLine("2. Rectangle");
        Console.WriteLine("3. Circle");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                CalculateTriangle();
                break;
            case 2:
                CalculateRectangle();
                break;
            case 3:
                CalculateCircle();
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }

        Console.ReadLine();
    }

    static void CalculateTriangle()
    {
        Console.WriteLine("Enter the base length of the triangle:");
        double baseLength = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height of the triangle:");
        double height = double.Parse(Console.ReadLine());

        double area = (baseLength * height) / 2;
        Console.WriteLine("The area of the triangle is: " + area);

        double perimeter = baseLength + 2 * (Math.Sqrt(Math.Pow(baseLength / 2, 2) + Math.Pow(height, 2)));
        Console.WriteLine("The perimeter of the triangle is: " + perimeter);

        double side = baseLength;
        Console.WriteLine("The side length of the triangle is: " + side);
    }

    static void CalculateRectangle()
    {
        Console.WriteLine("Enter the length of the rectangle:");
        double length = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the width of the rectangle:");
        double width = double.Parse(Console.ReadLine());

        double area = length * width;
        Console.WriteLine("The area of the rectangle is: " + area);

        double perimeter = 2 * (length + width);
        Console.WriteLine("The perimeter of the rectangle is: " + perimeter);

        double side = Math.Sqrt(Math.Pow(length, 2) + Math.Pow(width, 2));
        Console.WriteLine("The diagonal length of the rectangle is: " + side);
    }

    static void CalculateCircle()
    {
        Console.WriteLine("Enter the radius of the circle:");
        double radius = double.Parse(Console.ReadLine());

        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine("The area of the circle is: " + area);

        double perimeter = 2 * Math.PI * radius;
        Console.WriteLine("The circumference of the circle is: " + perimeter);

        double diameter = 2 * radius;
        Console.WriteLine("The diameter of the circle is: " + diameter);
    }
}