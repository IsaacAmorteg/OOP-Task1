using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GeometryClasses
{
    public class Square : Shape
    {
        private double _sideLength;

        public Square(double sideLength) 
        {
            _sideLength = sideLength;
        }

        public override double GetArea()
        {
            return _sideLength * _sideLength;
        }

        public override double GetPerimeter()
        {
            return 4 * _sideLength;
        }
    }
}
