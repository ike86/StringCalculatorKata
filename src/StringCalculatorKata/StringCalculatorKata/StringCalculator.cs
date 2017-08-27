using System;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            var tokens = numbers.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            var result = 0;
            foreach (var token in tokens)
            {
                result += int.Parse(token);
            }

            return result;
        }
    }
}