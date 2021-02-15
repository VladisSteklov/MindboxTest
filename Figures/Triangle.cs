using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Triangle : Figure
    {
        public double A { get; protected set; }
        public double B { get; protected set; }
        public double C { get; protected set; }

        public bool IsRectangular { get; protected set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;

            this.IsTriangleExist();

            // Полупериметр
            var p = (A + B + C) / 2.0;

            // Формула Герона
            Square = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            // Является треугольник прямоугольным
            IsRectangular = this.PifagorCheck(A, B, C) || PifagorCheck(B, A, C) || PifagorCheck(C, A, B);
        }

        // Для прямоугольного треугольника возможно выполнение равенства Пифагора
        private bool PifagorCheck(double a, double b, double c)
        {
            // a^2 = b^2 + c^2 ?
            return (a * a) == (b * b + c * c);
        }

        private void IsTriangleExist() 
        {
            if ((A > B + C) || (B > A + C) || (C > A + B) || (A <= 0) || (B <= 0) || (C <= 0))
            {
                throw new Exception("Треугольник с указанными длинами сторон не существует");
            }
        }

    }
}
