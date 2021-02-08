using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresUnitTests
{
    /// <summary>
    /// Сводное описание для TriangleTest
    /// </summary>
    [TestClass]
    public class TriangleTest
    {
        
        [TestMethod]
        public void TestSquare()
        {
            // Ожидаемая площадь по формуле Герона
            var expected = 6;

            var Triangle = new Triangle(3, 4, 5);

            Assert.AreEqual(expected, Triangle.Square);
        }

        [TestMethod]
        public void IsRectangularWhenRectangular()
        {
            // Треугольник прямоугольный
            var Triangle = new Triangle(3, 4, 5);

            Assert.IsTrue(Triangle.IsRectangular);
        }

        [TestMethod]
        public void IsRectangularWhenNotRectangular()
        {
            // Треугольник непрямоугольный
            var Triangle = new Triangle(3, 8, 9);

            Assert.IsFalse(Triangle.IsRectangular);
        }

        [TestMethod]
        public void IsTriangleExistWhenExist()
        {
            // Треугольник с такими параметрами существует - исключения не поймано - тест не пройден
            Assert.ThrowsException<Exception>(() => new Triangle(3, 4, 5));
        }

        [TestMethod]
        public void IsTriangleExistWhenNotExist()
        {
            // Треугольник не существует с такими параметрами - будет выдано исключение
            Assert.ThrowsException<Exception>(() => new Triangle(1, 1, 100));
        }
    }
}
