using System;
using System.Collections.Generic;
using System.Text;
using NDash;
using Xunit;

namespace NDash.Tests
{
    public class NDash_Unique_Tests
    {
        public class Positives
        {
            [Fact]
            public void when_values_are_unique()
            {
                var numbers = new[] { 1, 2, 3, 4, 5 };

                Assert.True(numbers.AreUnique());
            }

            [Fact]
            public void when_selected_values_are_unique()
            {
                var names = new[] { "JOHN", "john", "JANE", "jane" };

                Assert.True(names.AreUniqueBy(NDashLib.Identity));
            }
        }

        public class Negatives
        {
            [Fact]
            public void when_values_have_duplicates()
            {
                var numbers = new[] { 1, 2, 3, 2, 1 };

                Assert.False(numbers.AreUnique());
            }

            [Fact]
            public void when_selected_values_have_duplicates()
            {
                var names = new[] { "JOHN", "john", "JANE", "jane" };

                Assert.False(names.AreUniqueBy(name => name.ToLower()));
            }
        }
    }
}
