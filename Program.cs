using System;
namespace Polymorphism
{
    abstract class Shape
    {
        public abstract double CalculateArea();
    }

    class Rectangle : Shape
    {
        private double _length;
        private double _width;

        public double Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public override double CalculateArea()
        {
            return _length * _width;
        }
    }

    class Circle : Shape
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public override double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }
    }

    class Triangle : Shape
    {
        private double _base;
        private double _height;

        public double Base
        {
            get { return _base; }
            set { _base = value; }
        }

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public override double CalculateArea()
        {
            return 0.5 * _base * _height;
        }
    }

    class Program
    {
        static void Main()
        {
            Shape[] shapes = new Shape[]
            {
                new Rectangle { Length = 10, Width = 5 },
                new Circle { Radius = 7 },
                new Triangle { Base = 5, Height = 8 }
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"{shape.GetType().Name} Area: {shape.CalculateArea()}");
            }
        }
    }
}
