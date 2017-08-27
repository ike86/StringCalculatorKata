using System;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (numbers == string.Empty)
            {
                return 0;
            }

            var tokens = numbers.Split(',');
            if (tokens.Length > 1)
            {
                return int.Parse(tokens[0]) + int.Parse(tokens[1]);
            }

            return int.Parse(numbers);
        }
    }
}