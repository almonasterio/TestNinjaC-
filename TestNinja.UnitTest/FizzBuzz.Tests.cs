using NUnit.Framework;
using System;

using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void GetOutput_InputIsDivisibleBy3And5_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_InputIsDivisibleBy3_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(9);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_InputIsDivisibleBy5_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(25);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_InputIsNotDivisibleBy3Or5_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(4);

            Assert.That(result, Is.EqualTo("4"));
        }
    }
}
//CanBeCancelledBy_UserIsAdmin_ReturnsTrue()