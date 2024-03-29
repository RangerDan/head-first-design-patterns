# Singleton Pattern

  - Ensure there is only ever one instance of a class
  - Provide global access to it

## Demo Project

Choc-o-holic Boiler is a class for controlling a physical hot chocolate boiler.  We want our application to always control the state of the boiler no matter which class needs to work with it. So we made it a singleton.  Two versions are provided. A Singleton that is made synchronous using locks, and one that take advantage of C#'s `Lazy<T>`.

## Notes

- One instance means only one. That's the whole point. Different and better than global variables.
- In Java, this usually tsakes the form of a private constructor and a static method to grab the sole instance. But enums can simplify this.
- Think carefully about performance, resources, threading, etc.
- C# has different patterns than those mentioned in the book. I tried to find equivalents that bwere in the spirit of the instruction.

## References

- Mahesh Alle at c-sharpcorner.com covered [implementations of Singleton Patterns in C#](https://www.c-sharpcorner.com/UploadFile/8911c4/singleton-design-pattern-in-C-Sharp/) that follows the book pretty closely.
- Ted Nerward's [enum implementation at D-Zone](https://dzone.com/articles/singleton-implementation-in-c) was very helpful as well.