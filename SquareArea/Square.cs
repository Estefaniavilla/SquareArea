using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareArea
{

namespace CalculationAreaSquare
    {
        class Square
        {
            private double side;

           
            public Square(double l)
            {
                side = l;
            }

            
            public double CalculateArea()
            {
                return side * side;
            }
            
            public double CalculateArea(double broad)
            {
                return side * broad;
            }
        }
    }
}
