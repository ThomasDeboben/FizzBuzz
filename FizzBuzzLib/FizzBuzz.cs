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
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    /// <summary>
    /// The fizz buzz class.
    /// </summary>
    public class FizzBuzz
    {
        /// <summary>
        /// The rules.
        /// </summary>
        private readonly IList<Func<int, string, string>> rules = new List<Func<int, string, string>>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FizzBuzz"/> class.
        /// </summary>
        public FizzBuzz()
        {
            this.rules.Add(this.Fizzy);
            this.rules.Add(this.Buzzy);
            this.rules.Add(this.Other);
        }

        /// <summary>
        /// Get the fizz buzz formatted value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The fizz buzz formatted value<see cref="string"/>.</returns>
        public string GetFizzBuzzFormattedString(int value)
        {
            return this.rules.Aggregate(string.Empty, (current, rule) => rule(value, current));
        }

        /// <summary>
        /// The fizzy rule.
        /// Add fizz to the return string if the value is a multiple from 3 or contains a 3.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="returnString">The input return string.</param>
        /// <returns>The return string.</returns>
        public string Fizzy(int value, string returnString)
        {
            if (this.IsValueMultipleFromDivider(value, 3) || this.ValueContainsDigit(value, 3))
            {
                returnString += "Fizz";
            }

            return returnString;
        }

        /// <summary>
        /// The buzzy rule.
        /// Add buzz to the return string if the value is a multiple from 5 or contains a 5.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="returnString">The input return string.</param>
        /// <returns>The return string.</returns>
        public string Buzzy(int value, string returnString)
        {
            if (this.IsValueMultipleFromDivider(value, 5) || this.ValueContainsDigit(value, 5))
            {
                returnString += "Buzz";
            }

            return returnString;
        }

        /// <summary>
        /// The other rule.
        /// Format the value as return string if no other rule has set the return string before.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="returnString">The input return string.</param>
        /// <returns>The return string.</returns>
        public string Other(int value, string returnString)
        {
            if (string.IsNullOrEmpty(returnString))
            {
                returnString = string.Format("{0}", value);
            }

            return returnString;
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
