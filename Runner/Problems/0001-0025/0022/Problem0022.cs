using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

namespace Runner.Problems
{
    public class Problem0022 : Problem
    {
        private List<string> _names;

        public override object Solve()
        {
            BigInteger sum = 0;

            for (int i = 0; i < _names.Count; i++)
            {
                sum += Score(_names[i]) * (i + 1);
            }

            return sum;
        }

        private int Score(string name)
        {
            return name.ToCharArray().Select(p => p - 64).Sum();
        }

        public override void Initialize()
        {
            base.Initialize();

            var line = File.ReadAllLines(@"Problems\0022\data.txt")[0];
            _names = line.Split(',').Select(p => p.Trim('"')).OrderBy(p => p).ToList();
        }
    }
}