using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using static NDash.NDashLib;

namespace NDash.Tests
{
    public class NDash_AsFunc_Tests
    {
        [Fact]
        public void TestArity0()
        {
            int method() => 1;

            Assert.IsType<Func<int>>(AsFunc(method));
        }
    }
}
