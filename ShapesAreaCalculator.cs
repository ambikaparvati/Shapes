using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public static class ShapesAreaCalculator
    {
        public static Shape GetShape(int choice)
        {

            switch (choice)
            {
                case 1:
                    Circle circle = new Circle();
                    return circle;
                case 2:
                    Rectangle rectangle = new Rectangle();
                    return rectangle;
                case 3:
                    Triangle triangle = new Triangle();
                    return triangle;
                default: throw (new Exception("Invalid Choice"));
            }
        }
    }
    public abstract class Shape
    {
        public double area;
        public abstract Shape CalculateArea(params double[] list);
        public void Display()
        {
            Console.WriteLine("Area is : " + area);
        }
    }

    public class Circle : Shape
    {
        public override Shape CalculateArea(params double[] properties)
        {
            if (properties.Length != 1 || properties[0] < 0 || properties[0] > Math.Sqrt(Double.MaxValue))
            {
                throw (new Exception("Invalid property"));
            }
            area = Math.PI * properties[0] * properties[0];
            return this;
        }
    }
    public class Rectangle : Shape
    {
        public override Shape CalculateArea(params double[] properties)
        {
            if (properties.Length != 2 || properties[0] < 0 || properties[1] < 0)
            {
                throw (new Exception("Invalid property"));
            }
            area = properties[0] * properties[1];
            return this;
        }
    }
    public class Triangle : Shape
    {
        public override Shape CalculateArea(params double[] properties)
        {
            if (properties.Length != 2 || properties[0] < 0 || properties[1] < 0)
            {
                throw (new Exception("Invalid property"));
            }
            area = 0.5 * properties[0] * properties[1];
            return this;
        }
    }
}
