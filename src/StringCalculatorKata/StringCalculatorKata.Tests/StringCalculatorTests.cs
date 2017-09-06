using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace StringCalculatorKata.Tests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        [TestCase("", 0, TestName = "ReturnsZero_If_NumbersIsEmpty")]
        [TestCase("1", 1)]
        [TestCase("2", 2)]
        [TestCase("1,2", 3)]
        [TestCase("1,2,3", 6)]
        public void Returns_sum_If_Numbers_contains_numbers(string numbers, int expected)
        {
            var calculator = new StringCalculator();

            var sum = calculator.Add(numbers);

            sum.Should().Be(expected);
        }

        [Test]
        public void Returns_sum_If_Numbers_contains_numbers_with_mixed_separators()
        {
            var calculator = new StringCalculator(",", "\n");

            var sum = calculator.Add("1\n2,3");

            sum.Should().Be(6);
        }
    }
}
