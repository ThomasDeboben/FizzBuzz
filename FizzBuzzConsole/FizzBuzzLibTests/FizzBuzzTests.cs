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
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    using CSVReader;

    using FizzBuzzLib;
    using NUnit.Framework;

    /// <summary>
    /// The fizz buzz tests.
    /// </summary>
    public class FizzBuzzTests
    {
        /// <summary>
        /// The FizzBuzz string formatter test.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="expectedResult">The expected result.</param>
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(4, "4")]
        [TestCase(5, "Buzz")]
        [TestCase(6, "Fizz")]
        [TestCase(9, "Fizz")]
        [TestCase(12, "Fizz")]
        [TestCase(13, "Fizz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(18, "Fizz")]
        [TestCase(34, "Fizz")]
        [TestCase(29, "29")]
        [TestCase(34, "Fizz")]
        [TestCase(35, "FizzBuzz")]
        [TestCase(51, "FizzBuzz")]
        public void FizzBuzzTest(int value, string expectedResult)
        {
            var fizzBuzz = new FizzBuzz();
            Assert.AreEqual(expectedResult, fizzBuzz.GetFizzBuzzFormattedString(value));
        }

        /// <summary>
        /// The is value multiple from divider test.
        /// </summary>
        /// <param name="testData">The test data.</param>
        [Test, TestCaseSource("GetIsValueMultipleFromDividerTestData")]
        public void IsValueMultipleFromDividerTest(IsValueMultipleFromDividerTestData testData)
        {
            var fizzBuzz = new FizzBuzz();
            Assert.AreEqual(testData.ExpectedResult, fizzBuzz.IsValueMultipleFromDivider(testData.Value, testData.Divider));
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

        /// <summary>
        /// Gets the is value multiple from divider test data.
        /// </summary>
        /// <returns>The is value multiple from divider test data.</returns>
        private IEnumerable<IsValueMultipleFromDividerTestData> GetIsValueMultipleFromDividerTestData()
        {
            using (var csv = new CsvReader(@"..\..\TestData\DataForIsMultipleFromDivider.csv"))
            {
                while (csv.Next())
                {
                    var result = new IsValueMultipleFromDividerTestData
                                     {
                                         Value = int.Parse(csv[0]),
                                         Divider = int.Parse(csv[1]),
                                         ExpectedResult = bool.Parse(csv[2])
                                     };

                    yield return result;
                }
            }
        }

        /// <summary>
        /// Data struct for IsValueMultipleFromDividerTest
        /// </summary>
        public struct IsValueMultipleFromDividerTestData
        {
            /// <summary>
            /// The value
            /// </summary>
            public int Value;

            /// <summary>
            /// The divider
            /// </summary>
            public int Divider;

            /// <summary>
            /// The expected result
            /// </summary>
            public bool ExpectedResult;

            /// <summary>
            /// Returns a <see cref="System.String" /> that represents this instance.
            /// </summary>
            /// <returns> A <see cref="System.String" /> that represents this instance. </returns>
            public override string ToString()
            {
                return string.Format("{0} is multiple from {1} => {2}", this.Value, this.Divider, this.ExpectedResult);
            }
        }
    }
}
