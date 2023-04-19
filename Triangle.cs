using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryClasses
{
    class Triangle : Shape
    {
        private double _base;
        private double _height;
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public Triangle(double trianlgeBase, double height, double sideA, double sideB, double sideC)
        {
            _base = trianlgeBase;
            _height = height;
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }
        public override double GetArea()
        {
            return (_base * _height) / 2;
        }

        public override double GetPerimeter()
        {
            return _sideA + _sideB + _sideC;
        }
    }
}
