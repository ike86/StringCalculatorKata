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
        [Test]
        public void ReturnsZero_If_NumbersIsEmpty()
        {
            var calculator = new StringCalculator();

            var sum = calculator.Add(string.Empty);

            sum.Should().Be(0);
        }
    }
}
