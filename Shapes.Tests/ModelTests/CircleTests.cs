using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Circle_GetCircumference_CircumferenceOfCircle()
        {
            Circle newCircle = new Circle(4);
            double result = newCircle.GetCircumference();
            Assert.AreEqual(result, 25.12);
        }

        [TestMethod]
        public void Circle_GetDiameter_DiameterOfCircle()
        {
            Circle newCircle = new Circle(4);
            double result = newCircle.GetDiameter();
            Assert.AreEqual(result, 8);
        }
        
    
        
        
    }
}