using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//// using MSTestHacks;

namespace FizzBuzzLib.Tests
{
    [TestClass()]
    public class FizzBuzzTests
    {
        public IEnumerable<int> TestNumbers
        {
            get
            {
                //This could do anything, fetch a dynamic list from anywhere....
                return new List<int> { 1, 2, 3 };
            }
        }

        [TestMethod()]
        public void IsValueMultipleFromThreeTest()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.IsTrue(fizzBuzz.IsValueMultipleFromDivider(3, 3), "number is no multiple of divider");
            Assert.IsTrue(fizzBuzz.IsValueMultipleFromDivider(6, 3), "number is no multiple of divider");
            Assert.IsTrue(fizzBuzz.IsValueMultipleFromDivider(9, 3), "number is no multiple of divider");
            Assert.IsTrue(fizzBuzz.IsValueMultipleFromDivider(12, 3), "number is no multiple of divider");
            Assert.IsTrue(fizzBuzz.IsValueMultipleFromDivider(15, 3), "number is no multiple of divider");
            Assert.IsFalse(fizzBuzz.IsValueMultipleFromDivider(1, 3), "number is no multiple of divider");
            Assert.IsFalse(fizzBuzz.IsValueMultipleFromDivider(2, 3), "number is no multiple of divider");
            Assert.IsFalse(fizzBuzz.IsValueMultipleFromDivider(14, 3), "number is no multiple of divider");
        }

        [TestMethod()]
        public void IsValueMultipleFromFiveTest()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.IsTrue(fizzBuzz.IsValueMultipleFromDivider(5, 5), "number is no multiple of divider");
            Assert.IsTrue(fizzBuzz.IsValueMultipleFromDivider(10, 5), "number is no multiple of divider");
            Assert.IsTrue(fizzBuzz.IsValueMultipleFromDivider(15, 5), "number is no multiple of divider");
            Assert.IsTrue(fizzBuzz.IsValueMultipleFromDivider(20, 5), "number is no multiple of divider");
            Assert.IsFalse(fizzBuzz.IsValueMultipleFromDivider(1, 5), "number is no multiple of divider");
            Assert.IsFalse(fizzBuzz.IsValueMultipleFromDivider(2, 5), "number is no multiple of divider");
            Assert.IsFalse(fizzBuzz.IsValueMultipleFromDivider(14, 5), "number is no multiple of divider");
        }

        [TestMethod()]
        public void ValueContainsDigitTest()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.IsTrue(fizzBuzz.ValueContainsDigit(5, 5), "value does not contain digit");
            Assert.IsTrue(fizzBuzz.ValueContainsDigit(15, 5), "value does not contain digit");
            Assert.IsTrue(fizzBuzz.ValueContainsDigit(25, 5), "value does not contain digit");
            Assert.IsTrue(fizzBuzz.ValueContainsDigit(35, 5), "value does not contain digit");
            Assert.IsFalse(fizzBuzz.ValueContainsDigit(10, 5), "value does contain digit");
        }
    }
}
