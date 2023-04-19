using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GeometryClasses
{
    class Square : Shape
    {
        private double _sideLenght;

        public Square(double sideLenght) 
        {
            _sideLenght = sideLenght;
        }
        public override double GetArea()
        {
            return _sideLenght * _sideLenght;
        }

        public override double GetPerimeter()
        {
            return 4 * _sideLenght;
        }
    }
}
