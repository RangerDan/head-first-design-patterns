# Iterator Pattern

- Provides a way to access the elements of an aggregate object sequentially.
- Does not expose the underlying implementation.

## Demo Project

Welcome to Flavortown! Using the Menus example from the book, this project uses iterators from disparate aggregates like Lists and Arrays without needing to maintain code for the individual implementations.

## Notes

- Iterators allow some client to access elements of an underlying collection like arrays, lists, hashes, etc, without caring about how they are implemented.
- This separation allows the client to access contents of the collection without needing to know how those collections are structured or the iteration is done.
- The iterators allow the client to be polymorphic. The same bit of code can handle any type of collection.
- IEnumerable<T> in C# (Iterable in Java) can be implemented to have a class provide iterator support in ways that can take advantage of language features like foreach and LINQ.
- By using iterators, we allow the single-responsibility of a class. The client doesn't need to worry about _how_ the collection chooses to iterate. The collection doesn't need to change if the client wants to iterate over its members in a new fashion. They can vary independently.

## Examples and References

- I know my code sample is not as technically challenging as the text presents it. I created a PancakeHouseEnumerator for practice, but it is not used in the sample project itself.
- C# is a little more modern in its implementation of the Iterator pattern than Java. Relatively primitive collections implement IEnumerable<T>. Even basic arrays have access to the .AsEnumerable<T>() method. As long as you are only depending on that interface, you can pass around a ton of enumerable lists.
- Early .Net Framework had non-generic IEnumerables, and they are largely seen as obsolete.  [Here is a great thread on Code Ranch on implementing collection types](https://coderanch.com/t/716157/languages/generic-collections-obsolete) that is from when this change first started to happen.
- C# iterators can [use the keyword `yield`](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/yield) to control how the next items are returned. `yield return <var>` returns a value, while `yield break` signals the end of the iteration.