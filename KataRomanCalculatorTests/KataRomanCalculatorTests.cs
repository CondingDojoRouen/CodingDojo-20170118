using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingDojo
{
    [TestClass]
    public class KataRomanCalculatorTests
    {
        [TestClass]
        public class KataRomanCalculator_Add
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

            [TestMethod]
            public void AddingIAndIIIReturnsIV()
            {
                //Arrange
                string n1 = "I";
                string n2 = "III";
                //Act
                string result = KataRomanCalculator.Add(n1, n2);
                //Assert
                Assert.AreEqual("IV", result);
            }

            [TestMethod]
            public void AddingVIIAndIIReturnsIX()
            {
                //Arrange
                string n1 = "VII";
                string n2 = "II";
                //Act
                var result = KataRomanCalculator.Add(n1, n2);
                //Assert
                Assert.AreEqual("IX", result);
            }
        }
        [TestClass]
        public class KataRomanCalculator_Compute
        {
            [TestMethod]
            public void ComputeRoman()
            {
                //Arrange
                string n1 = "VII";
                //Act
                var result = KataRomanCalculator.Compute(n1);
                //Assert
                Assert.AreEqual(7, result);
            }
            [TestMethod]
            public void ComputeRomanLIXShouldReturn59()
            {
                //Arrange
                string n1 = "LIX";
                //Act
                var result = KataRomanCalculator.Compute(n1);
                //Assert
                Assert.AreEqual(59, result);
            }
        }
        
    }
}
