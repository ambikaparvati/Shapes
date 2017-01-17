using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            for (;;)
            {
                Console.WriteLine("Enter Options :");
                Console.WriteLine("1. Circle 2. Rectangle 3. Triangle");
                int choice = Int32.Parse(Console.ReadLine());
                Shape shape = ShapesAreaCalculator.GetShape(choice);
                string propertiesInput = Console.ReadLine();
                double[] properties = Array.ConvertAll(propertiesInput.Split(' '), Double.Parse);
                shape.CalculateArea(properties).Display();
            }
        }
    }
}
