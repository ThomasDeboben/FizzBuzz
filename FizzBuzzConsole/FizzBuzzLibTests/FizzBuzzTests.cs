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
        /// <param name="testData">The test data.</param>
        [Test, TestCaseSource("GetGetFizzBuzzFormattedStringTestData")]
        public void GetFizzBuzzFormattedStringTest(GetFizzBuzzFormattedStringTestData testData)
        {
            var fizzBuzz = new FizzBuzz();
            Assert.AreEqual(testData.ExpectedResult, fizzBuzz.GetFizzBuzzFormattedString(testData.Value));
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
        /// <param name="testData">The test data.</param>
        [Test, TestCaseSource("GetValueContainsDigitTestData")]
        public void ValueContainsDigitTest(ValueContainsDigitTestData testData)
        {
            var fizzBuzz = new FizzBuzz();
            Assert.AreEqual(testData.ExpectedResult, fizzBuzz.ValueContainsDigit(testData.Value, testData.Digit));
        }

        /// <summary>
        /// Gets the get fizz buzz formatted string test data.
        /// </summary>
        /// <returns>The get fizz buzz formatted string test data.</returns>
        private IEnumerable<GetFizzBuzzFormattedStringTestData> GetGetFizzBuzzFormattedStringTestData()
        {
            using (var csv = new CsvReader(@"..\..\TestData\DataForGetFizzBuzzFormattedString.csv"))
            {
                while (csv.Next())
                {
                    var result = new GetFizzBuzzFormattedStringTestData
                    {
                        Value = int.Parse(csv[0]),
                        ExpectedResult = csv[1].Trim()
                    };

                    yield return result;
                }
            }
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
        /// Gets the value contains digit test data.
        /// </summary>
        /// <returns>The value contains digit test data.</returns>
        private IEnumerable<ValueContainsDigitTestData> GetValueContainsDigitTestData()
        {
            using (var csv = new CsvReader(@"..\..\TestData\DataForValueContainsDigit.csv"))
            {
                while (csv.Next())
                {
                    var result = new ValueContainsDigitTestData
                    {
                        Value = int.Parse(csv[0]),
                        Digit = int.Parse(csv[1]),
                        ExpectedResult = bool.Parse(csv[2])
                    };

                    yield return result;
                }
            }
        }

        /// <summary>
        /// Data struct for GetFizzBuzzFormattedStringTest
        /// </summary>
        public struct GetFizzBuzzFormattedStringTestData
        {
            /// <summary>
            /// The value
            /// </summary>
            public int Value;

            /// <summary>
            /// The expected result
            /// </summary>
            public string ExpectedResult;

            /// <summary>
            /// Returns a <see cref="System.String" /> that represents this instance.
            /// </summary>
            /// <returns> A <see cref="System.String" /> that represents this instance. </returns>
            public override string ToString()
            {
                return string.Format("{0} => {1}", this.Value, this.ExpectedResult);
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

        /// <summary>
        /// Data struct for ValueContainsDigitTest
        /// </summary>
        public struct ValueContainsDigitTestData
        {
            /// <summary>
            /// The value
            /// </summary>
            public int Value;

            /// <summary>
            /// The digit
            /// </summary>
            public int Digit;

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
                return string.Format("{0} contains digit {1} => {2}", this.Value, this.Digit, this.ExpectedResult);
            }
        }
    }
}
