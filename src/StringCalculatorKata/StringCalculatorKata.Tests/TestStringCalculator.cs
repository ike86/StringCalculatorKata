using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using StringCalculatorKata;

namespace StringCalculatorKata.Tests
{
    [TestFixture]
    public class TestStringCalculator
    {
        [TestCase("", 0, TestName = "Add returns Zero if numbers is empty")]
        [TestCase("1", 1)]
        [TestCase("2", 2)]
        [TestCase("1,2", 3)]
        [TestCase("1,2,3", 6)]
        public void Add_returns_self_if_numbers_contains_one_number(string numbers, int expected)
        {
            var calculator = new StringCalculator();

            var result = calculator.Add(numbers);

            result.Should().Be(expected);
        }
    }
}
