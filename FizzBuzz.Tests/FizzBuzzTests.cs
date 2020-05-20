using System;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Get_returns_1_for_1()
        {
            var fizzBuzz = new fizzBuzz();
            var result = fizzBuzz.Get(1);
            Assert.Equal("1", result);
        }

        [Fact]
        public void Get_returns_2_for_2()
        {
            var fizzBuzz = new fizzBuzz();
            var result = fizzBuzz.Get(2);
            Assert.Equal("2", result);
        }
        [Fact]
        public void Get_returns_Fizz_for_3()
        {
            var fizzBuzz = new fizzBuzz();
            var result = fizzBuzz.Get(3);
            Assert.Equal("Fizz", result);
        }
    }
}
