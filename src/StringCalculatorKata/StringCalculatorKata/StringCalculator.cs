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

            if (HasSeparator(numbers))
            {
                var separator = GetSeparator(numbers);

                return numbers.Split(new[] { separator }, StringSplitOptions.RemoveEmptyEntries)
                    .Where(x => x != "//")
                    .Select(x => int.Parse(x))
                    .Sum();
            }

            return numbers.Split(this.separators, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .Sum();
        }

        private static bool HasSeparator(string numbers)
        {
            return numbers.StartsWith("//");
        }

        private static string GetSeparator(string numbers)
        {
            var tokens = numbers.Split(new[] { "\n" }, StringSplitOptions.None);
            var separator = tokens.First().Substring(2);
            if (separator == string.Empty)
            {
                separator = "\n";
            }

            return separator;
        }
    }
}