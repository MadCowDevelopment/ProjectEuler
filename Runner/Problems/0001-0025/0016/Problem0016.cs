using System.Linq;
using System.Numerics;

namespace Runner.Problems
{
    public class Problem0016 : Problem
    {
        public override object Solve()
        {
            BigInteger pow = 2;
            for (var i = 1; i < 1000; i++) pow *= 2;
            return pow.ToString().Aggregate<char, BigInteger>(0, (current, t) => current + int.Parse(t.ToString()));
        }
    }
}