// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="R&S">
// Copyright 2014  
// </copyright>
// <summary>
// The fizzbuzz console program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FizzBuzzConsole
{
    using System;
    using FizzBuzzLib;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main method.
        /// </summary>
        /// <param name="args">The args.</param>
        public static void Main(string[] args)
        {
            var fizzbuzz = new FizzBuzz();

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fizzbuzz.GetFizzBuzzFormattedString(i));
            }

            Console.ReadLine();
        }
    }
}
