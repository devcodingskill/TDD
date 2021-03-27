using System;
using NUnit.Framework;

namespace TDDTest
{
    public class StringCalcutorKata
    {

        [Test]
        public void Add_EmptyStringAsParam_ReturnsZero()
        {
            Assert.AreEqual(0, StringCalculator.Add(string.Empty));
        }
        [Test]
        public void Add_StringContainingSingleNumber_ReturnsTheNumberItself()
        {

            var input = "5";
            var expectResult = 5;
            Assert.AreEqual(expectResult, StringCalculator.Add(input));
        }

        [Test]
        public void Add_TwoNumbersSeparatedByComma_ReturnsTheirSum()
        {
            var numbers = "7,8";
            var expectedResult = 15;
            Assert.AreEqual(expectedResult, StringCalculator.Add(numbers));
        }
        [Test]
        public void Add_ThreeNumbersSeparatedByComma_ReturnsTheirSum()
        {
            var numbers = "1, 2, 3";
            var expected = 6;
            Assert.AreEqual(expected, StringCalculator.Add(numbers));
        }

        [TestCase("1,2,3,4", 10)]
        [TestCase("8,7,20", 35)]
        [TestCase("5,0,4,1001", 1010)]
        [TestCase("5,0,4,1000", 1009)]
        [TestCase("26,6,90", 122)]
        public void Add_MoreThanThreeNumbersSeparatedByComma_ReturnsTheirSum(string input, int result)
        {
            Assert.AreEqual(result, StringCalculator.Add(input));
        }

        [TestCase("1,2,3,4,5,-5")]
        [TestCase("-1,1,2,9")]
        [TestCase("5,6,8,-5")]
        public void Add_StringContainingNegativeNumbers_Throws(string numbers)
        {
            Assert.Throws<ArgumentException>(() => StringCalculator.Add(numbers));
        }
    }
}
