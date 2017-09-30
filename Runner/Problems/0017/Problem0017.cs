namespace Runner.Problems
{
    public class Problem0017 : Problem
    {
        public override object Solve()
        {
            var result = 0;
            for (var i = 1; i <= 1000; i++) result += NumberToString(i).Length;
            return result;
        }

        private string NumberToString(int number)
        {
            string result = string.Empty;

            if (number >= 1000)
            {
                var thousands = number / 1000;
                result += NumberToString(thousands);
                result += "thousand";
                if (number % 1000 != 0) result += "and";
                number -= thousands * 1000;
            }

            if (number >= 100)
            {
                var hundreds = number / 100;
                result += NumberToString(hundreds);
                result += "hundred";
                if (number % 100 != 0) result += "and";
                number -= hundreds * 100;
            }

            if (number >= 20)
            {
                var tens = number / 10;
                if (number >= 90) result += "ninety";
                else if (number >= 80) result += "eighty";
                else if (number >= 70) result += "seventy";
                else if (number >= 60) result += "sixty";
                else if (number >= 50) result += "fifty";
                else if (number >= 40) result += "forty";
                else if (number >= 30) result += "thirty";
                else if (number >= 20) result += "twenty";
                number -= tens * 10;
            }

            if (number > 0)
            {
                switch (number)
                {
                    case 1: result += "one"; break;
                    case 2: result += "two"; break;
                    case 3: result += "three"; break;
                    case 4: result += "four"; break;
                    case 5: result += "five"; break;
                    case 6: result += "six"; break;
                    case 7: result += "seven"; break;
                    case 8: result += "eight"; break;
                    case 9: result += "nine"; break;
                    case 10: result += "ten"; break;
                    case 11: result += "eleven"; break;
                    case 12: result += "twelve"; break;
                    case 13: result += "thirteen"; break;
                    case 14: result += "fourteen"; break;
                    case 15: result += "fifteen"; break;
                    case 16: result += "sixteen"; break;
                    case 17: result += "seventeen"; break;
                    case 18: result += "eighteen"; break;
                    case 19: result += "nineteen"; break;
                }
            }


            return result.Trim();
        }
    }
}