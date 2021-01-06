using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NDash.Tests
{
    public class NDash_Negate_Tests
    {
        [Fact]
        public void TestArity0()
        {
            Func<bool> no = () => false;

            var yes = no.Negate();

            Assert.True(yes());
        }

        [Fact]
        public void TestArity1()
        {
            Func<int, bool> isEven = i => i % 2 == 0;

            var isOdd = NDashLib.Negate(isEven);

            Assert.True(isEven(4));
            Assert.True(isOdd(5));
        }
    }
}
