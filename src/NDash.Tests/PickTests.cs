using NDash.Tests.TestClasses;
using System.Collections.Generic;
using Xunit;

namespace NDash.Tests
{
    public class PickTests
    {
        public class DictionaryVariant
        {
            [Fact]
            public void should_pick_requested_properties()
            {
                var joseph = new Developer("Joseph", "Hart", 25);

                Dictionary<string, object> ageless = NDashLib.Pick(joseph, "FirstName", "LastName");

                Assert.Equal(2, ageless.Count);
                Assert.Equal("Joseph", ageless["FirstName"]);
                Assert.Equal("Hart", ageless["LastName"]);
            }
        }

        public class ExpandoVariant
        {
            [Fact]
            public void should_pick_requested_properties()
            {
                var joseph = new Developer("Joseph", "Hart", 25);

                dynamic ageless = NDashLib.PickExpando(joseph, "FirstName", "LastName");

                Assert.Equal(2, (ageless as IDictionary<string, object>).Count);
                Assert.Equal("Joseph", ageless.FirstName);
                Assert.Equal("Hart", ageless.LastName);
            }
        }

        public class GenericVariant
        {
            class AgelessDeveloper
            {
                public string FirstName { get; private set; }
                public string LastName { get; private set; }
                public string MiddleName { get; private set; }
            }

            [Fact]
            public void should_pick_requested_properties()
            {
                var joseph = new Developer("Joseph", "Hart", 25);

                AgelessDeveloper ageless = NDashLib.Pick<AgelessDeveloper>(joseph, "FirstName", "LastName");

                Assert.Equal("Joseph", ageless.FirstName);
                Assert.Equal("Hart", ageless.LastName);
                Assert.Null(ageless.MiddleName);
            }
        }
    }
}
