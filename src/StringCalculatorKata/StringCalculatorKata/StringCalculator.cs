using System.Linq;

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

            return numbers.Split(',')
                .Select(x => int.Parse(x))
                .Sum();
        }
    }
}