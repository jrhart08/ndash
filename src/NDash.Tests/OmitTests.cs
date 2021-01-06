using NDash.Tests.TestClasses;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using Xunit;

namespace NDash.Tests
{
    public class OmitTests
    {
        public class DictionaryVariant
        {
            [Fact]
            public void should_omit_requested_properties()
            {
                var joseph = new Developer("Joseph", "Hart", 30);

                Dictionary<string, object> nameless = NDashLib.Omit(joseph, "FirstName", "LastName");

                Assert.Single(nameless);
                Assert.Equal(30, nameless["Age"]);
            }
        }

        public class ExpandoVariant
        {
            [Fact]
            public void should_omit_requested_properties()
            {
                var joseph = new Developer("Joseph", "Hart", 30);

                dynamic nameless = NDashLib.OmitExpando(joseph, "FirstName", "LastName");

                Assert.Equal(30, nameless.Age);
            }
        }

        public class GenericVariant
        {
            class NamelessDeveloper
            {
                public int Age { get; private set; }
                public bool IsGettingPromotionForThis { get; private set; }
            }

            [Fact]
            public void should_omit_requested_properties()
            {
                var joseph = new Developer("Joseph", "Hart", 30);

                NamelessDeveloper nameless = NDashLib.Omit<NamelessDeveloper>(joseph, "FirstName", "LastName");

                Assert.Equal(30, nameless.Age);
                Assert.False(nameless.IsGettingPromotionForThis);
            }
        }
    }
}
