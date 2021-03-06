﻿using System;

namespace Runner.Problems
{
    //Starting with the number 1 and moving to the right in a clockwise direction a 5 by 5 spiral is formed as follows:
    //21 22 23 24 25
    //20  7  8  9 10
    //19  6  1  2 11
    //18  5  4  3 12
    //17 16 15 14 13
    //It can be verified that the sum of the numbers on the diagonals is 101.
    //What is the sum of the numbers on the diagonals in a 1001 by 1001 spiral formed in the same way?
    public class Problem0028 : Problem
    {
        public override object Solve()
        {
            var columns = 1001;
            double result = 1; // 1 by 1 spiral has value 1;
            for (int i = 3; i <= columns; i+=2)
            {
                result += 4 * Math.Pow(i, 2) - 6 * (i - 1);
            }

            return result;
        }
    }
}