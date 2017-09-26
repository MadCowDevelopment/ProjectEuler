using System;

namespace Runner.Problems
{
    public class Problem0012 : IProblem
    {
        public object Solve()
        {
            var current = 0;
            for (var i = 1; i < 100000; i++)
            {
                current += i;
                if (CalculateDivisors(current) > 500) return current;
            }

            throw new InvalidOperationException("Couldn't find a solution.");
        }

        private int CalculateDivisors(int number)
        {
            int count = 2;

            int i = 2;
            int max = number / 2;
            while (i < max)
            {
                if (number % i == 0)
                {
                    count++;

                    var dividend = number / i;
                    if (dividend != i) count++;
                    max = dividend;
                }
                i++;
            }

            return count;
        }

        public void Initialize()
        {
        }
    }
}