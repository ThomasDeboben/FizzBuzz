// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FizzBuzzTests.cs" company="FizzBuzz">
// Copyright 2014  
// </copyright>
// <summary>
//   The fizz buzz tests.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FizzBuzzLibTests
{
    using FizzBuzzLib;
    using NUnit.Framework;

    /// <summary>
    /// The fizz buzz tests.
    /// </summary>
    public class FizzBuzzTests
    {
        []
        public void FizzBuzzTest(int value, string expectedResult)
        {
            var fizzBuzz = new FizzBuzz();
            Assert.AreEqual(fizzBuzz.IsValueMultipleFromDivider(i, 3));
        }

        /// <summary>
        /// The is value multiple from divider test.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="divider">The divider.</param>
        /// <param name="expectedResult">The expected Result.</param>
        [TestCase(1, 3, false)]
        [TestCase(2, 3, false)]
        [TestCase(3, 3, true)]
        [TestCase(4, 3, false)]
        [TestCase(5, 3, false)]
        [TestCase(6, 3, true)]
        [TestCase(9, 3, true)]
        [TestCase(12, 3, true)]
        [TestCase(15, 3, true)]
        [TestCase(18, 3, true)]
        [TestCase(1, 5, false)]
        [TestCase(2, 5, false)]
        [TestCase(3, 5, false)]
        [TestCase(4, 5, false)]
        [TestCase(5, 5, true)]
        [TestCase(6, 5, false)]
        [TestCase(9, 5, false)]
        [TestCase(10, 5, true)]
        [TestCase(15, 5, true)]
        [TestCase(20, 5, true)]
        public void IsValueMultipleFromDividerTest(int value, int divider, bool expectedResult)
        {
            var fizzBuzz = new FizzBuzz();
            Assert.AreEqual(expectedResult, fizzBuzz.IsValueMultipleFromDivider(value, divider));
        }

        /// <summary>
        /// The does value contains a digit test.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="digit">The digit.</param>
        /// <param name="expectedResult">The expected Result.</param>
        [TestCase(1, 3, false)]
        [TestCase(2, 3, false)]
        [TestCase(3, 3, true)]
        [TestCase(13, 3, true)]
        [TestCase(35, 3, true)]
        [TestCase(51, 5, true)]
        public void ValueContainsDigitTest(int value, int digit, bool expectedResult)
        {
            var fizzBuzz = new FizzBuzz();
            Assert.AreEqual(expectedResult, fizzBuzz.ValueContainsDigit(value, digit));
        }
    }
}
