// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FizzBuzz.cs" company="R&S">
// Copyright 2014  
// </copyright>
// <summary>
// Defines the FizzBuzz type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FizzBuzzLib
{
    using System.Globalization;

    /// <summary>
    /// The fizz buzz class.
    /// </summary>
    public class FizzBuzz
    {
        /// <summary>
        /// Get the fizz buzz formatted value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The fizz buzz formatted value<see cref="string"/>.</returns>
        public string GetFizzBuzzFormattedString(int value)
        {
            var result = string.Empty;

            var fizz = this.IsValueMultipleFromDivider(value, 3) || this.ValueContainsDigit(value, 3);
            var buzz = this.IsValueMultipleFromDivider(value, 5) || this.ValueContainsDigit(value, 5);

            if (fizz)
            {
                result = string.Concat(result, "Fizz");
            }

            if (buzz)
            {
                result = string.Concat(result, "Buzz");
            }

            if (string.IsNullOrEmpty(result))
            {
                result = string.Format("{0}", value);
            }

            return result;
        }

        /// <summary>
        /// Checks if the value is a multiple from the divider.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="divider">The divider.</param>
        /// <returns>True if the value is a multiple from the divider, false if not.</returns>
        public bool IsValueMultipleFromDivider(int value, int divider)
        {
            return 0 == value % divider;
        }

        /// <summary>
        /// Checks if the value contains the digit.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="digit">The digit.</param>
        /// <returns>True if the value contains the digit, false if not.</returns>
        public bool ValueContainsDigit(int value, int digit)
        {
            return value.ToString(CultureInfo.InvariantCulture).Contains(digit.ToString(CultureInfo.InvariantCulture));
        }
    }
}
