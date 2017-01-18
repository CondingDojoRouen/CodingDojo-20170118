using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingDojo
{
    [TestClass]
    public class KataRomanCalculatorTests
    {
        [TestMethod]
        public void Adding2EmptyStringReturnsEmptyString()
        {
            //Arrange
            //Act
            string result = KataRomanCalculator.Add(String.Empty, String.Empty);
            //Assert
            Assert.AreEqual(String.Empty, result);
        }

        [TestMethod]
        public void AddingEmptyStringAndOneReturnsOne()
        {
            //Arrange
            string n1 = string.Empty;
            string n2 = "I";
            //Act
            string result = KataRomanCalculator.Add(n1, n2);
            //Assert
            Assert.AreEqual("I", result);
        }
    }
}
