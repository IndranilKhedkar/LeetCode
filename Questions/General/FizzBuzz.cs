using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using System;
using System.Collections.Generic;

namespace General
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/fizz-buzz/
    /// Write a program that outputs the string representation of numbers from 1 to n.
    /// But for multiples of three it should output “Fizz” instead of the number and for the multiples of five output “Buzz”. 
    /// For numbers which are multiples of both three and five output “FizzBuzz”.
    /// </summary>
    public class FizzBuzz : Question
    {
        public IList<string> OutputFizzBuzz(int n)
        {
            List<string> result = new List<string>();
            const string Fizz = "Fizz";
            const string Buzz = "Buzz";
            const string FizzBuzz = "FizzBuzz";

            for (int i = 1; i <= n; i++)
            {
                bool isDivisibleBy3 = i % 3 == 0;
                bool isDivisibleBy5 = i % 5 == 0;

                if (isDivisibleBy3 && isDivisibleBy5)
                {
                    result.Add(FizzBuzz);
                }
                else if (isDivisibleBy5)
                {
                    result.Add(Buzz);
                }
                else if (isDivisibleBy3)
                {
                    result.Add(Fizz);
                }
                else
                {
                    result.Add(i.ToString());
                }
            }

            return result;
        }

        public override void Run()
        {
            var result = OutputFizzBuzz(5);

            result = OutputFizzBuzz(3);
        }
    }
}
