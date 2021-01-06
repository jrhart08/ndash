# ndash
General-purpose utility and extension methods

# IEnumerable Extensions

## AreUnique (`IEnumerable<T>` -> `bool`)
Returns `true` if all elements in a collection are are unique.

Usage:
```cs
bool yes = new[] { 1, 2, 3, 4, 5 }.AreUnique();
// -> true
```

## CryptoShuffle (`IEnumerable<T>` -> `IEnumerable<T>`)
Returns a shuffled copy of the collection, using a cryptographically secure random number generator (just because).

Usage:
```cs
IEnumerable<int> shuffled = new[] { 1, 2, 3, 4, 5 }.Shuffle();
// -> [3, 1, 4, 2, 5]
// (or some other randomized order)
```

## Disjunction (`(IEnumerable<T>, IEnumerable<T>)` -> `DisjunctionResult<T>`)
Returns the left and right collections, minus overlapping values.

Usage:
```cs
var left  = new[] { 1, 2, 3 };
var right = new[] { 3, 4, 5 };

var (leftOnly, rightOnly) = left.Disjunction(right);
// leftOnly = [1, 2]
// rightOnly = [4, 5]
```

## DisjunctiveUnion (`(IEnumerable<T>, IEnumerable<T>)` -> `IEnumerable<T>`)
Returns a the left collection concatenated by the right collection, minus overlapping values.

Usage:
```cs
var left  = new[] { 1, 2, 3 };
var right = new[] { 3, 4, 5 };

var everythingButIntersection = left.DisjunctiveUnion(right);
// -> [1, 2, 4, 5]
```

## Flatten (`IEnumerable<IEnumerable<T>>` -> `IEnumerable<T>`)
Flattens a nested collection. Synonymous with `nestedCollection.SelectMany(list => list)`.

Usage:
```cs
int[][] matrix = new[]
{
    new[] { 1, 2, 3 },
    new[] { 4, 5, 6 },
    new[] { 7, 8, 9 },
};

int[] array = matrix.Flatten();
// -> [1, 2, 3, 4, 5, 6, 7, 8, 9]
```

## ForEach (`(IEnumerable<T>, Action<T>)` -> `void`)
Like `List<T>.ForEach`, but usable on any IEnumerable

Usage:
```cs
var countries = new[] { "Canada", "United States", "Mexico" };

countries.ForEach(Console.WriteLine);
```

## Merge (`(IDictionary<K, V>, IDictionary<K, V>)` -> `IDictionary<K, V>`)
Merges 2 dictionaries, with the left dictionary winning on key conflicts.

Usage:
```cs
var person = new Dictionary<string, string>
{
    { "First Name", "John" },
    { "Last Name",  "Doe"  },
};

var employee = new Dictionary<string, string>
{
    { "First Name", "Chris"        },
    { "Last Name",  "Cringle"      },
    { "Occupation", "Delivery man" },
};

var merged = person.Merge(employee);
/*
{
    "First Name": "John",
    "Last Name": "Doe",
    "Occupation": "Delivery man"
}
*/
```

## MergeRight (`(IDictionary<K, V>, IDictionary<K, V>)` -> `IDictionary<K, V>`)
Merges 2 dictionaries, with the *right* dictionary winning on key conflicts.

## SeparateBy (`(IEnumerable<T>, Func<T, bool>)` -> `SeparateByResult<T>`)
Separates the collection into 2 collections: 1 with elements where the predicate is true, and the other where it's false.

Usage:
```cs
int IsEven(number) => number % 2 == 0;

var numbers = new[] { 1, 2, 3, 4, 5 };

var (evens, odds) = numbers.SeparateBy(IsEven);
// evens = [2, 4]
// odds = [1, 3, 5]
```

## Shuffle (`IEnumerable<T>` -> `IEnumerable<T>`)
Copies and shuffles the collection.

Optionally accepts a custom `Random` object, or a `Func<int, int>` random number generator.

If given a custom callback, provides the number of elements in the array.

Usage:
```cs
var cards = new[] { 1, 2, 3, 4, 5 };
var shuffled = cards.Shuffle();
// [3, 2, 4, 5, 1]
// (or some other randomized order)
```

Usage (custom shuffler):
```cs
using RNG = System.Security.Cryptography.RandomNumberGenerator;

var cards = new[] { 1, 2, 3, 4, 5 };

// synonymous with `cards.CryptoShuffle()`
var wellShuffled = cards.Shuffle(count => RNG.GetInt32(count));
```

## Swap (`(IList<T>, int, int)` -> `IList<T>`)
Swaps the elements at 2 indices. ***This mutates the original list!***

Usage:
```cs
var letters = new[] { "a", "b", "c", "d" };
letters.Swap(0, 3);
// -> ["d", "b", "c", "a"]
```
