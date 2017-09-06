using System;
using System.Linq;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        private readonly string[] separators;

        public StringCalculator()
            : this(",")
        {
        }

        public StringCalculator(params string[] separators)
        {
            this.separators = separators;
        }

        public int Add(string numbers)
        {
            if (numbers == string.Empty)
            {
                return 0;
            }

            return numbers.Split(this.separators, StringSplitOptions.None)
                .Select(x => int.Parse(x))
                .Sum();
        }
    }
}