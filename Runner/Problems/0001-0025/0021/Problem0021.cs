using System;
using System.Collections.Generic;
using System.Linq;
using Runner.Utils;

namespace Runner.Problems
{
    public class Problem0021 : Problem
    {
        public override object Solve()
        {
            var tuples = new List<Tuple<int, int>>(10000);

            for (var i = 0; i < 10000; i++)
            {
                var properDivisors = i.GetProperDivisors();
                tuples.Add(new Tuple<int, int>(i, properDivisors.Sum()));
            }

            var amicableNumbers =
                from a in tuples
                from b in tuples
                where a.Item1 != b.Item1 && a.Item1 == b.Item2 && a.Item2 == b.Item1
                select new Tuple<int, int>(a.Item1, b.Item1);

            var distinct = new HashSet<int>();
            foreach (var amicableNumber in amicableNumbers)
            {
                if (!distinct.Contains(amicableNumber.Item1)) distinct.Add(amicableNumber.Item1);
                if (!distinct.Contains(amicableNumber.Item2)) distinct.Add(amicableNumber.Item2);
            }

            return distinct.Sum();
        }
    }
}