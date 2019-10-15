using System;

namespace Runner.Problems
{
    public class Problem0019 : Problem
    {
        public override object Solve()
        {
            var sundays = 0;
            for (var year = 1901; year < 2001; year++)
            {
                for (var month = 1; month < 13; month++)
                {
                    var day = new DateTime(year, month, 1);
                    if (day.DayOfWeek == DayOfWeek.Sunday) sundays++;
                }
            }

            return sundays;
        }
    }
}