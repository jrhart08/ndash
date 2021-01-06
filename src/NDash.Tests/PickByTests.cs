using NDash.Tests.TestClasses;
using System.Collections.Generic;
using System.Dynamic;
using Xunit;

namespace NDash.Tests
{
    public class PickByTests
    {
        public class Arity1
        {
            public class DictionaryVariant
            {
                [Fact]
                public void should_pick_matching_properties()
                {
                    var joseph = new Developer("Joseph", null, 30);

                    Dictionary<string, object> nonNils = NDashLib.PickBy(joseph, val => val != default);

                    Assert.Equal(2, nonNils.Count);
                    Assert.Equal("Joseph", nonNils["FirstName"]);
                    Assert.Equal(30, nonNils["Age"]);
                }
            }

            public class ExpandoVariant
            {
                [Fact]
                public void should_pick_matching_properties()
                {
                    var joseph = new Developer("Joseph", null, 30);

                    dynamic nonNils = NDashLib.PickByExpando(joseph, val => val != default);

                    Assert.Equal("Joseph", nonNils.FirstName);
                    Assert.Equal(30, nonNils.Age);
                }
            }

            public class GenericVariant
            {
                class AnonymousDeveloper
                {
                    public string FirstName { get; private set; }
                    public int Age { get; private set; }
                }
                [Fact]
                public void should_pick_matching_properties()
                {
                    var joseph = new Developer("Joseph", null, 30);

                    AnonymousDeveloper nonNils = NDashLib.PickBy<AnonymousDeveloper>(joseph, val => val != default);

                    Assert.Equal("Joseph", nonNils.FirstName);
                    Assert.Equal(30, nonNils.Age);
                }
            }
        }

        public class Arity2
        {
            static bool IsNameProperty(object value, string propertyName) =>
                propertyName.EndsWith("Name");

            public class DictionaryVariant
            {
                [Fact]
                public void should_pick_matching_properties()
                {
                    var joseph = new Developer("Joseph", "Hart", 30);

                    Dictionary<string, object> ageless = NDashLib.PickBy(joseph, IsNameProperty);

                    Assert.Equal(2, ageless.Count);
                    Assert.Equal("Joseph", ageless["FirstName"]);
                    Assert.Equal("Hart", ageless["LastName"]);
                }
            }

            public class ExpandoVariant
            {
                [Fact]
                public void should_pick_matching_properties()
                {
                    var joseph = new Developer("Joseph", "Hart", 30);

                    dynamic ageless = NDashLib.PickByExpando(joseph, IsNameProperty);

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
                public void should_pick_matching_properties()
                {
                    var joseph = new Developer("Joseph", "Hart", 30);

                    AgelessDeveloper ageless = NDashLib.PickBy<AgelessDeveloper>(joseph, IsNameProperty);

                    Assert.Equal("Joseph", ageless.FirstName);
                    Assert.Equal("Hart", ageless.LastName);
                    Assert.Null(ageless.MiddleName);
                }
            }
        }
    }
}
