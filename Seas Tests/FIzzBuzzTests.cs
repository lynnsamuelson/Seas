using System;
using Seas;
using Xunit;

namespace Seas_Tests
{
    public class FizzBuzzTests
    {
        
        [Fact]
        public void FizzBuzzNotDivisibleByFizzOrBuzz()
        {
            var seas = new FizzBuzz();
            var fizzBuzz = seas.FizzBuzzMethod(1, 2, 3);
            Assert.Equal("1", fizzBuzz);
        }

        [Fact]
        public void FizzBuzzDivisibleByFizzNotBuzz()
        {
            var seas = new FizzBuzz();
            var fizzBuzz = seas.FizzBuzzMethod(2, 2, 3);
            Assert.Equal("Fizz", fizzBuzz);
        }

        [Fact]
        public void FizzBuzzDivisibleByBuzzNotFizz()
        {
            var seas = new FizzBuzz();
            var fizzBuzz = seas.FizzBuzzMethod(2, 3, 2);
            Assert.Equal("Buzz", fizzBuzz);
        }
    }
}
