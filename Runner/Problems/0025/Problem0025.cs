using System.Numerics;

namespace Runner.Problems
{
    public class Problem0025 : Problem
    {
        public override object Solve()
        {
            int index = 2;
            BigInteger previous = 1;
            BigInteger current = 1;
            do
            {
                var temp = current + previous;
                previous = current;
                current = temp;
                index++;
            } while (current.ToString().Length < 1000);
            return index;
        }
    }
}