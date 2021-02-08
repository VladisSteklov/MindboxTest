using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Circle: Figure
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
            // pi * r^2
            Square = Math.PI * Math.Pow(_radius, 2);
        }
    }
}
