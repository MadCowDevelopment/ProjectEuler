using System.Collections.Generic;
using System.Linq;
using Runner.Utils;

namespace Runner.Problems
{
    class Problem0023 : Problem
    {
        public override object Solve()
        {
            var abundantNumbers = GetAbundantNumbers();

            var sum = Enumerable.Range(1, 23).Sum();

            var sumsOfAbundantNumbers = new HashSet<int>(
                from a in abundantNumbers
                from b in abundantNumbers
                select a + b);

            for (int i = 25; i < 28123; i++)
            {
                if (!sumsOfAbundantNumbers.Contains(i)) sum += i;
            }

            return sum;
        }

        private static List<int> GetAbundantNumbers()
        {
            var result = new List<int>();

            for (int i = 1; i < 28123; i++)
            {
                var divisors = i.GetProperDivisors();
                if (divisors.Sum() > i) result.Add(i);
            }

            return result;
        }
    }
}
