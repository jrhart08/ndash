using System.Collections.Generic;
using Xunit;

namespace NDash.Tests
{
    public class MergeTests
    {
        static Dictionary<string, string> GetDict1() => new Dictionary<string, string>
        {
            { "abc", "123" },
            { "def", "456" },
        };

        static Dictionary<string, string> GetDict2() => new Dictionary<string, string>
        {
            { "def", "000" },
            { "ghi", "789" },
        };

        public class Merge
        {
            [Fact]
            public void first_should_win()
            {
                var winner = GetDict1();
                var loser = GetDict2();
                var merged = winner.Merge(loser);

                Assert.Equal(3, merged.Count);
                Assert.Equal("123", merged["abc"]);
                Assert.Equal("456", merged["def"]);
                Assert.Equal("789", merged["ghi"]);
            }
        }

        public class MergeRight
        {
            [Fact]
            public void second_should_win()
            {
                var winner = GetDict2();
                var loser = GetDict1();
                var merged = loser.MergeRight(winner);

                Assert.Equal(3, merged.Count);
                Assert.Equal("123", merged["abc"]);
                Assert.Equal("000", merged["def"]);
                Assert.Equal("789", merged["ghi"]);
            }
        }
    }
}
