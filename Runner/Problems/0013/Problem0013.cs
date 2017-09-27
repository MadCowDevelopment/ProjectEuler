using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Runner.Problems
{
    public class Problem0013 : IProblem
    {
        private List<string> _numbers = new List<string>();
        public object Solve()
        {
            var digits = new List<int>();
            int borrow = 0;
            for (int i = 11; i >= 0; i--)
            {
                var sum = _numbers.Sum(p => int.Parse(p[i].ToString())) + borrow;
                var sumString = sum.ToString();
                var lastDigit = int.Parse(sumString[sumString.Length - 1].ToString());
                borrow = (sum - lastDigit) / 10;

                digits.Add(lastDigit);
            }

            if (borrow > 0)
            {
                var borrowString = borrow.ToString();

                for (int i = borrowString.Length - 1; i >= 0; i--)
                {
                    var digit = int.Parse(borrowString[i].ToString());
                    digits.Add(digit);
                }
            }

            digits.Reverse();

            var result = decimal.Parse(string.Join("", digits.Take(10)));

            return result;
        }

        public void Initialize()
        {
            var lines = File.ReadAllLines(@"Problems\0013\data.txt");
            _numbers = lines.ToList();
        }
    }
}