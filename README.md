# Head First Design Patterns - Book Notes

Sample projects and notes from the excellent Head First Design Patterns, Second Edition (Freeman, et al. _Design Patterns_. O'Reilly, 2014)

## Big Concepts:

### OO Basics

- Abstraction
- Encapsulation
- Polymorphism
- Inheritance

### OO Principles

1. Encapsulate what varies
2. Favor composition over inheritance
3. Program to an interface and not an implementation
4. Strive for loosely-coupled designs between objects that interact
5. Open for extension, closed for modification
6. Depend on abstractions; do not depend on concrete classes (Dependency Inversion)
7. Talk only to your friends (Principle of Least Knowledge/Law of Demeter)
8. Don't call us; we'll call you. (Hollywood Principle)
9. A class should only have one reason to change.

## Patterns (in chapter order)

* [Strategy](./src/strategy/README.md)

  - Encapsulate each one
  - Make them interchangeable
  - Vary algorithm independently from the clients that use it

* [Observer](./src/observer/README.md)

  - Define one-to-many dependency
  - When an object changes state, all its dependents are notified.

* [Decorator](./src/decorator/README.md)

  - Attaches additional responsibilities to an object dynamically.
  - Provides a flexible alternative to subclassing for extending functionality.

* [Factory Method](./src/factory/README.md)

  - Factory Method defines an interface for creating a _single_ object, but let subclasses decide what to instantiate. I.e.: the class defers instatiation to the subclasses.
  - Abstract Factory provides an interface for creating _families_ of objects without specifying their concrete classes.

* [Singleton](./src/singleton/README.md)

  - Ensure there is only ever one instance of a class.
  - Provide global access to that instance.

* [Command](./src/command/README.md)

  Encapsulates a request as an object to parameterize clients with different requests, queue or log requests, and support undo operations.

* [Adapter](./src/adapter/README.md)

  - Converts one interface into another its clients expect.
  - Allows otherwise incompatible classes to work together.

* [Facade](./src/facade/README.md)

  - Provides a unified interface to a set of interfaces in a subsystem.
  - Defines a higher-level interface that makes the subsystem easier to use.

* [Template Method](./src/templatemethod/README.md)

  - Defines the skeleton of an algorithm in the superclass and relies on subclasses to implement the final part of it.
  - Allows subclasses to redefine portions of an algorithm without changing the algorithm's structure.

* [Iterator](./src/iterator/README.md)

  - Provides a way to access the elements of an aggregate object sequentially.
  - Does not expose the underlying implementation.

* [Composite](./src/composite/README.md)

  - Allows you to composite objects into tree-like structures to represent part/whole hierarchies.
  - Clients can treat individual and composite components uniformly.

# Toolbox

- You need [.NET 6](https://www.dot.net) to run these examples.
- Projects created with `dotnet new console --use-program-main -n AppName`
- Used https://github.com/d0pare to compare solutions, get formatting hints, and crib dotnet style.