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
        [Test]
        public void Add_ReturnsZero_If_NumbersIsEmpty()
        {
            var calculator = new StringCalculator();

            var result = calculator.Add(string.Empty);

            result.Should().Be(0);
        }
    }
}
