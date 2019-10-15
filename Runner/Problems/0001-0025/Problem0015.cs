using System.Numerics;

namespace Runner.Problems
{
    public class Problem0015 : Problem
    {
        public const int Size = 20;

        public override object Solve()
        {
            var coeffs = new BigInteger[Size, Size];

            for (var i = 0; i < Size; i++)
            {
                coeffs[0, i] = 1;
            }

            for (var i = 1; i < Size; i++)
            {
                for (var j = 0; j < Size; j++)
                {
                    BigInteger current = 0;

                    for (var k = j; k < Size; k++)
                    {
                        current += coeffs[i - 1, k];
                    }

                    coeffs[i, j] = current;
                }
            }

            BigInteger sum = 1;
            for (var i = 0; i < Size; i++)
            {
                for (var j = 0; j < Size; j++)
                {
                    sum += coeffs[i, j];
                }
            }

            return sum;
        }
    }
}