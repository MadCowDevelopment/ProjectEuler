using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

namespace Runner.Problems
{
    public class Problem0018 : Problem
    {
        private readonly List<List<BigInteger>> _data = new List<List<BigInteger>>();
        
        public override object Solve()
        {
            for (var row = _data.Count - 2; row >= 0; row--)
            {
                for (var column = 0; column < row + 1; column++)
                {
                    var element = _data[row][column];
                    var child1 = _data[row + 1][column];

                    var child2 = _data[row + 1][column + 1];

                    if (child1 > child2) element += child1;
                    else element += child2;

                    _data[row][column] = element;
                }
            }

            return _data[0][0];
        }

        public override void Initialize()
        {
            base.Initialize();

            var lines = File.ReadAllLines(@"Problem0018.dat");
            foreach (var line in lines)
            {
                _data.Add(line.Split(' ').Select(item => BigInteger.Parse(item.Trim())).ToList());
            }
        }
    }
}