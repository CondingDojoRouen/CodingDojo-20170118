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
    }
}
