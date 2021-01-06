using NDash.Tests.TestClasses;
using System.Linq;
using Xunit;

namespace NDash.Tests
{
    public class DisjunctionTests
    {
        public class given_empty_left_collection
        {
            [Fact]
            public void should_return_full_right_collection()
            {
                var left = new int[] { };
                var right = new int[] { 1, 2, 3 };

                var (exclusiveToLeft, exclusiveToRight) = left.Disjunction(right);

                Assert.Empty(exclusiveToLeft);
                Assert.Equal(right, exclusiveToRight);
            }
        }

        public class given_empty_right_collection
        {
            [Fact]
            public void should_return_full_left_collection()
            {
                var left = new int[] { 1, 2, 3 };
                var right = new int[] { };

                var (exclusiveToLeft, exclusiveToRight) = left.Disjunction(right);

                Assert.Equal(left, exclusiveToLeft);
                Assert.Empty(exclusiveToRight);
            }
        }

        public class given_common_elements
        {
            [Fact]
            public void should_omit_common_elements_from_left_and_right()
            {
                var left  = new[] { 1, 2, 3, 4 };
                var right = new[] {       3, 4, 5, 6 };

                var (exclusiveToLeft, exclusiveToRight) = left.Disjunction(right);

                Assert.Equal(new[] { 1, 2 }, exclusiveToLeft);
                Assert.Equal(new[] { 5, 6 }, exclusiveToRight);
            }
        }

        public class given_collections_of_classes
        {
            static string GetLastName(Developer dev) => dev.LastName;

            [Fact]
            public void should_omit_elements_with_common_keys()
            {
                var leftDevs = new[]
                {
                    new Developer("John", "Doe", 25),
                    new Developer("Jotaro", "Kujo", 18),
                    new Developer("Star", "Platinum", 999),
                };

                var rightDevs = new[]
                {
                    new Developer("Jane", "Doe", 30),
                    new Developer("Joseph", "Joestar", 20),
                    new Developer("Hermit", "Purple", 999),
                };

                var (leftOnly, rightOnly) = leftDevs.Disjunction(rightDevs, GetLastName);

                Assert.Equal(new[] { "Kujo", "Platinum" }, leftOnly.Select(GetLastName));
                Assert.Equal(new[] { "Joestar", "Purple" }, rightOnly.Select(GetLastName));
            }
        }

        public class given_collections_of_different_classes
        {
            static string GetLastName(Developer founder) => founder.LastName;
            static string GetMake(Car car) => car.Make;

            [Fact]
            public void should_separate_by_left_and_right_selectors()
            {
                var founders = new[]
                {
                    new Developer("Soichiro", "Honda", 84),
                    new Developer("Elon", "Musk", 49),
                    new Developer("Mother", "Russia", 100),
                };

                var cars = new[]
                {
                    new Car("Honda", "Civic", 2000),
                    new Car("Tesla", "Cybertruck", 2021),
                    new Car("Zastava", "Yugo", 1980),
                };

                var (foundersMinusHonda, carsMinusHonda) = founders.Disjunction(cars, GetLastName, GetMake);

                Assert.Equal(new[] { "Musk", "Russia" }, foundersMinusHonda.Select(GetLastName));
                Assert.Equal(new[] { "Tesla", "Zastava" }, carsMinusHonda.Select(GetMake));
            }
        }
    }
}
