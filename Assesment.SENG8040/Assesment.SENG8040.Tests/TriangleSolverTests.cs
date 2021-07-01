using NUnit.Framework;
using Assesment.SENG8040;

namespace Assesment.SENG8040.Tests
{
    [TestFixture]
    public class TriangleSolverTests
    {
        [Test]
        //Test to determine a triangle is EquilateralTriangle based on the inputs provided with numbers
        public void EquilateralTriangle()
        {
            var message = TriangleSolver.Analyze(6, 6, 6);
            Assert.AreEqual(TriangleType.EquilateralTriangle, message);
        }
        [Test]
        //Test to determine a triangle is IsoscelesTriangle based on the inputs provided with numbers
        public void IsoscelesTriangle()
        {
            var message = TriangleSolver.Analyze(2, 2,5);
            Assert.AreEqual(TriangleType.IsoscelesTriangle, message);
        }
        [Test]
        //Test to determine a triangle is ScaleneTriangle based on the inputs provided with numbers
        public void ScaleneTriangle()
        {
            var message = TriangleSolver.Analyze(3, 4, 6);
            Assert.AreEqual(TriangleType.ScaleneTriangle, message);
        }
        [Test]
        //Test to determine not a triangle based on the inputs provided with numbers
        public void Triangle_ZeroValues()
        {
            var message = TriangleSolver.Analyze(0, 0, 0);
            Assert.AreEqual(TriangleType.NotTriangle, message);
        }
        [Test]
        //Test to determine a triangle is NotTriangle based on the inputs provided with null values
        public void Triangle_NullValues()
        {
            var message = TriangleSolver.Analyze(null, null, null);
            Assert.AreEqual(TriangleType.NotTriangle, message);
        }
        [Test]
        //Test to determine a triangle is NotTriangle based on the inputs provided with negative values
        public void Triangle_NegativeValues()
        {
            var message = TriangleSolver.Analyze(-1, -1, -1);
            Assert.AreEqual(TriangleType.NotTriangle, message);
        }
        [Test]
        //Test to determine a triangle is NotTriangle based on the inputs provided with null and negative values
        public void Triangle_NullAndNegativeValues()
        {
            var message = TriangleSolver.Analyze(null, null, -1);
            Assert.AreEqual(TriangleType.NotTriangle, message);
        }
        [Test]
        //Test to determine a triangle is NotTriangle based on the inputs provided with null and negative and zerO values
        public void Triangle_NullNegativeZeroValues()
        {
            var message = TriangleSolver.Analyze(null, 0, -1);
            Assert.AreEqual(TriangleType.NotTriangle, message);
        }
    }
}