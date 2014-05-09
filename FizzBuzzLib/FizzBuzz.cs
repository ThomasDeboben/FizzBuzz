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

            var fizz = this.IsValueMultipleFromDivider(value, 3);
            var buzz = this.IsValueMultipleFromDivider(value, 5);

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
        private bool IsValueMultipleFromDivider(int value, int divider)
        {
            return 0 == value % divider;
        }
    }
}
