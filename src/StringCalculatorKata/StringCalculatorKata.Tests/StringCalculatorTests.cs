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
        public void ReturnsNumber_If_NumbersContainsANumber(string numbers, int expected)
        {
            var calculator = new StringCalculator();

            var sum = calculator.Add(numbers);

            sum.Should().Be(expected);
        }
    }
}
