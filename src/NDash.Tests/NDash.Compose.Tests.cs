using System;
using Xunit;
using NDash.Tests.TestClasses;

namespace NDash.Tests
{
    public class NDash_Compose_Tests
    {
        static readonly Func<Developer, string> getFullName = dev => $"{dev.FirstName} {dev.LastName}";

        static readonly Func<string, string> hello = name => $"Hello, {name}";

        static readonly Func<string, string> exclaim = str => $"{str}!";

        static readonly Func<string, string> yell = str => str.ToUpper();

        [Fact]
        public void should_be_chainable()
        {
            var joseph = new Developer("Joseph", "Hart", 25);

            Func<Developer, string> veryExcitedGreeting = getFullName
                .Compose(exclaim)
                .Compose(yell)
                .Compose(hello);

            Assert.Equal("Hello, JOSEPH HART!", veryExcitedGreeting(joseph));
        }

        [Fact]
        public void should_be_chainable_indefinitely()
        {
            int GetLength(string greeting) => greeting.Length;

            var joseph = new Developer("Joseph", "Hart", 25);

            Func<Developer, int> greetingLength = getFullName
                .Compose(hello)
                .Compose(exclaim)
                .Compose(yell)
                .Compose(GetLength);

            Assert.Equal(19, greetingLength(joseph));
        }

        [Fact]
        public void should_execute_funcs_in_order()
        {
            Func<int, int> add5 = x => x + 5;
            Func<int, int> times2 = x => x * 2;

            Assert.Equal(10, add5.Compose(times2)(0));
        }
    }
}
