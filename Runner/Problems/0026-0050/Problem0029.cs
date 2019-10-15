using System;
using System.Collections.Generic;

namespace Runner.Problems
{
    public class Problem0029 : Problem
    {
        public override object Solve()
        {
            var numbers = new HashSet<double>();
            for (int a = 2; a <= 100; a++)
            {
                for (int b = 2; b <= 100 ; b++)
                {
                    var product = Math.Pow(a, b);
                    if (!numbers.Contains(product)) numbers.Add(product);
                }
            }

            return numbers.Count;
        }
    }
}