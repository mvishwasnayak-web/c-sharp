using System;

namespace areaparameter
{
    public abstract class Shape
    {
        public abstract double Area();
        public abstract double Perimeter();
    }

    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double Area()
        {
            return length * width;
        }

        public override double Perimeter()
        {
            return 2 * (length + width);
        }
    }
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Shape rect = new Rectangle(4, 5);
            Shape circ = new Circle(3);

            Console.WriteLine("Rectangle Area: " + rect.Area());
            Console.WriteLine("Rectangle Perimeter: " + rect.Perimeter());

            Console.WriteLine("Circle Area: " + circ.Area());
            Console.WriteLine("Circle Perimeter: " + circ.Perimeter());
            Console.ReadLine(); 
        }
    }
}

