using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Runner.Utils
{
    public static class IntegerExtensions
    {
        public static IEnumerable<int> GetProperDivisors(this int number)
        {
            var result = new List<int>();
            result.Add(1);

            for (var i = 2; i <= number/2; i++)
            {
                if (number % i == 0) result.Add(i);
            }

            return result;
        }
    }
}