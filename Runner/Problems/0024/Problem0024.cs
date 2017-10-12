using System.Collections.Generic;

namespace Runner.Problems
{
    public class Problem0024 : Problem
    {
        public override object Solve()
        {
            const int targetPermutation = 1000000;
            var remainder = targetPermutation - 1;

            var factors = new int[] { 362880, 40320, 5040, 720, 120, 24, 6, 2, 1, 1 };

            var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                
                var factor = factors[i];
                if (remainder >= factor)
                {
                    var times = remainder / factor;
                    remainder -= factor * times;
                    result.Add(numbers[times]);
                    numbers.RemoveAt(times);
                }
                else
                {
                    result.Add(numbers[0]);
                    numbers.RemoveAt(0);
                }
            }

            return string.Join("", result);
        }
    }
}