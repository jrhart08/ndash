using Xunit;

namespace NDash.Tests
{
    public class DisjunctiveUnionTests
    {
        public class given_no_selector
        {
            [Fact]
            public void should_omit_common_elements()
            {
                var left  = new[] { 1, 2, 3, 4 };
                var right = new[] {       3, 4, 5, 6 };

                var uniqueNumbers = left.DisjunctiveUnion(right);

                Assert.Equal(new[] { 1, 2, 5, 6 }, uniqueNumbers);
            }
        }

        public class given_selector
        {
            static int Mod10(int num) => num % 10;

            [Fact]
            public void should_omit_elements_with_common_keys()
            {
                var left  = new[] { 11, 12, 13, 14 };
                var right = new[] {         23, 24, 25, 26 };

                var uniqueMod10s = left.DisjunctiveUnion(right, Mod10);

                Assert.Equal(new[] { 11, 12, 25, 26 }, uniqueMod10s);
            }
        }
    }
}
