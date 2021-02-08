using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresUnitTests
{
    /// <summary>
    /// Сводное описание для CircleTest
    /// </summary>
    [TestClass]
    public class CircleTest
    {

        [TestMethod]
        public void TestSquare()
        {
            var radius = 5;
            var expected = Math.PI * radius * radius;

            Figure Circle = new Circle(radius);

            Assert.AreEqual(expected, Circle.Square);
        }
    }
}
