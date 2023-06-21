using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectOrientedDesign
{
    enum ShapeType
    {
        Circle,
        Square,
        Triangle
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Square square = new Square(5);
            Triangle triangle = new Triangle(10, 10);

            double circleArea = circle.CalculateArea();
            double squareArea = square.CalculateArea();
            double triangleArea = triangle.CalculateArea();

            Console.WriteLine("円の面積: " + circleArea);
            Console.WriteLine("正方形の面積: " + squareArea);
            Console.WriteLine("三角形の面積:" + triangleArea);
        }
    }

    
}
