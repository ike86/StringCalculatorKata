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
        public void Returns_Sum_If_NumbersContains_Numbers(string numbers, int expected)
        {
            var calculator = new StringCalculator();

            var sum = calculator.Add(numbers);

            sum.Should().Be(expected);
        }
    }
}
