using System;
using System.Numerics;

namespace Runner.Problems
{
    public class Problem0014 : Problem
    {
        public override object Solve()
        {
            long longest = 0;
            long numberForLongest = 1;

            for (var i = 2; i < 1000000; i++)
            {
                var length = 1;
                long current = i;
                
                while (current > 1)
                {
                    length++;
                    current = current % 2 == 0 ? (current / 2) : (3 * current + 1);
                }

                if (length > longest)
                {
                    longest = length;
                    numberForLongest = i;
                }
            }

            return numberForLongest;
        }
    }
}