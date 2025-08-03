using System;

namespace AbstractClassApp
{
    // Abstract class Shape
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    // Derived class Circle
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public double GetRadius()
        {
            return radius;
        }
    }

    // Derived class Rectangle
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width * height;
        }

        public double GetWidth()
        {
            return width;
        }

        public double GetHeight()
        {
            return height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Abstract Classes and Methods Demo ===");
            Console.WriteLine();

            // Create instances of Circle and Rectangle
            Circle circle = new Circle(5.0);
            Rectangle rectangle = new Rectangle(4.0, 6.0);

            // Display their areas
            Console.WriteLine($"Circle with radius {circle.GetRadius()}:");
            Console.WriteLine($"Area = {circle.GetArea():F2}");

            Console.WriteLine($"\nRectangle with width {rectangle.GetWidth()} and height {rectangle.GetHeight()}:");
            Console.WriteLine($"Area = {rectangle.GetArea():F2}");

            // Demonstrate polymorphism with abstract class
            Console.WriteLine("\n=== Polymorphism with Abstract Class ===");
            Shape[] shapes = { new Circle(3.0), new Rectangle(2.5, 4.0), new Circle(7.2) };

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine($"Shape {i + 1} area: {shapes[i].GetArea():F2}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
