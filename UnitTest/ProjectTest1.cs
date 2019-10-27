using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTest
{
    [TestClass]
    public class ProjectTest1
    {
        [TestMethod]
        public void TestGetFullName1()
        {
            // Arrange
            ConsoleApp_UnitTest.Program oProgram = new ConsoleApp_UnitTest.Program();

            // Act
            string result = oProgram.GetFullName("John", "Smith");

            // Assert
            Assert.AreEqual("John Smith", result);
        }

        [TestMethod]
        public void TestGetFullName2()
        {
            // Arrange
            ConsoleApp_UnitTest.Program oProgram = new ConsoleApp_UnitTest.Program();

            // Act
            string result = oProgram.GetFullName("     John ", " Smith   ");

            // Assert
            Assert.AreEqual("John Smith", result);
        }

        [TestMethod]
        public void TestGetFullName3()
        {
            // Arrange
            ConsoleApp_UnitTest.Program oProgram = new ConsoleApp_UnitTest.Program();

            // Act
            string result = oProgram.GetFullName("", " Smith   ");

            // Assert
            Assert.AreEqual("Smith", result);
        }


    }
}
