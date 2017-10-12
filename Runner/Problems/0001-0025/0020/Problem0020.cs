using System.Linq;
using System.Numerics;

namespace Runner.Problems
{
    public class Problem0020 : Problem
    {
        public override object Solve()
        {
            BigInteger factorial = 1;

            for (var i = 2; i <= 100; i++)
            {
                factorial *= i;
            }

            return factorial.ToString().Select(p => int.Parse(p.ToString()))
                .Aggregate<int, BigInteger>(0, (current, digit) => current + digit);
        }
    }
}