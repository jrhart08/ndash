using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NDash.Tests
{
    public class CurryTests
    {
        [Fact]
        public void should_return_2_nested_functions()
        {
            string append(string a, string b) => a + b;

            Assert.Equal(
                append("a", "b"),
                NDashLib.Curry<string, string, string>(append)("a")("b")
            );
        }

        [Fact]
        public void should_return_3_nested_functions()
        {
            Func<string, string, string, string> append = (a, b, c) => a + b + c;

            Assert.Equal(
                append("a", "b", "c"),
                append.Curry()("a")("b")("c")
            );
        }

        [Fact]
        public void should_return_4_nested_functions()
        {
            string append(string a, string b, string c, string d) => a + b + c + d;

            var partial = NDashLib.Curry<string, string, string, string, string>(append)("a")("b")("c");
            
            Assert.Equal(
                append("a", "b", "c", "d"),
                partial("d")
            );

            Assert.NotEqual(partial("d"), partial("e"));
        }
    }
}
