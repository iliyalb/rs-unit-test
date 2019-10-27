using System;
using MathLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class ProjectTest2
    {
        [TestMethod]
        public void TestAdd()
        {
            // Arrange
            CustomMath oMath = new CustomMath(7, 5);

            // Act
            int result = oMath.Add();

            // Assert
            Assert.AreEqual<int>(12, result);
        }

        [TestMethod]
        public void TestSub()
        {
            // Arrange
            CustomMath oMath = new CustomMath(10, 3);

            // Act
            int result = oMath.Sub();

            // Assert
            Assert.AreEqual<int>(7, result);
        }
    }
}

