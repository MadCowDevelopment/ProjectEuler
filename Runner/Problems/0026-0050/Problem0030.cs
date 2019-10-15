using System;
using System.Collections.Generic;
using System.Linq;

namespace Runner.Problems
{
    public class Problem0030 : Problem
    {
        public override object Solve()
        {
            var powers = new Dictionary<int, int>
                { {0,0},{1, 1}, {2, 32}, {3,243}, {4, 1024}, {5, 3125}, {6, 7776}, {7,16807}, {8,32768}, {9,59049} };
            var foundNumbers = new List<int>();

            for (var numberOfDigits = 2; numberOfDigits <= 6; numberOfDigits++)
            {
                // Init with as many ones as we have digits
                var digits = InitCurrentDigits(numberOfDigits);

                while (Increment(ref digits))
                {
                    var sum = digits.Sum(p => powers[p]);
                    var number = DigitsToNumber(digits);
                    if (sum == number)
                    {
                        foundNumbers.Add(sum);
                    }
                }
            }

            foreach (var foundNumber in foundNumbers)
            {
                Console.WriteLine(foundNumber);
            }

            return foundNumbers.Sum();
        }

        private bool Increment(ref int[] digits)
        {
            if (digits.All(p => p == 9)) return false;

            var number = DigitsToNumber(digits);
            number++;

            digits = NumberToDigits(number).Reverse().ToArray();
            return true;
        }

        private static IEnumerable<int> NumberToDigits(int number)
        {
            do
            {
                yield return number % 10;
                number /= 10;
            } while (number > 0);
        }

        private static int[] InitCurrentDigits(int numberOfDigits)
        {
            var currentDigits = new int[numberOfDigits];
            for (var j = 0; j < numberOfDigits; j++)
            {
                currentDigits[j] = 1;
            }

            return currentDigits;
        }

        private int DigitsToNumber(int[] currentNumbers)
        {
            int number = 0;
            for (var i = 0; i < currentNumbers.Length; i++)
            {
                var multiplier = (int)Math.Pow(10, currentNumbers.Length - i - 1);
                number += currentNumbers[i] * multiplier;
            }

            return number;
        }
    }
}