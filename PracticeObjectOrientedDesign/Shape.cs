using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectOrientedDesign
{
    class Circle : IShape
    {
        double Radius = 0;

        public Circle(double _radius)
        {
            Radius = _radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    class Square : IShape
    {
        double SideLength = 0;

        public Square(double _sideLength)
        {
            SideLength = _sideLength;
        }
        public double CalculateArea()
        {
            return SideLength * SideLength;
        }
    }

    class Triangle: IShape
    {
        double bottom = 0;
        double height = 0;

        public Triangle(double _bottom,double _height)
        {
            bottom = _bottom;
            height = _height;
        }

        public double CalculateArea()
        {
            return bottom * height / 2;
        }
    }

    public interface IShape
    {
        double CalculateArea();
    }
}
