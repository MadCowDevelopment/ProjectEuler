using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Runner.Problems._0011
{
    public class Problem0011 : IProblem
    {
        private const int Rows = 20;
        private const int Cols = 20;

        private readonly int[,] _data = new int[Rows, Cols];

        public object Solve()
        {
            var tuples = new List<Tuple<int, int, int, int>>();
            for (int row = 0; row < 20; row++)
            {
                for (int column = 0; column < 20; column++)
                {
                    if(column < 17) tuples.Add(new Tuple<int, int, int, int>(_data[row, column], _data[row, column+1], _data[row, column+2], _data[row, column+3]));
                    if(column < 17 && row < 17) tuples.Add(new Tuple<int, int, int, int>(_data[row, column], _data[row+1, column+1], _data[row+2, column+2], _data[row+3, column+3]));
                    if(row < 17) tuples.Add(new Tuple<int, int, int, int>(_data[row, column], _data[row+1, column], _data[row+2, column], _data[row+3, column]));
                    if(row > 3 && column < 17) tuples.Add(new Tuple<int, int, int, int>(_data[row, column], _data[row-1, column +1], _data[row-2, column+2], _data[row-3, column+3]));
                }
            }
            
            return tuples.Max(p => p.Item1 * p.Item2 * p.Item3 * p.Item4);
        }

        public void Initialize()
        {
            try
            {
                var reader = new StreamReader(@"Problems\0011\data.txt");
                var line = "";
                var i = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] tmp = line.Split(' ');
                    for (int j = 0; j < tmp.Length; j++)
                    {
                        _data[i, j] = int.Parse(tmp[j]);
                    }
                    i++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
