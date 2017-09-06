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

            var separators = this.separators;
            if (HasSeparator(numbers))
            {
                var tokens = numbers.Split(new[] { "\n" }, StringSplitOptions.None);
                var separator = tokens.First().Substring(2);

                numbers = tokens[1];
                separators = new[] { separator };
            }

            return numbers.Split(separators, StringSplitOptions.None)
                .Select(x => int.Parse(x))
                .Sum();
        }

        private static bool HasSeparator(string numbers)
        {
            return numbers.StartsWith("//");
        }
    }
}