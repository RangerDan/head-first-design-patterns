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
4. Open for extension, closed for modification
5. Dependency Inversion: Depend on abstractions; do not depend on concrete classes

## Patterns

* [Strategy](./src/strategy/README.md)

  - Encapsulate each one
  - Make them interchangeable
  - Vary algorithm independently from the clients that use it

* [Observer](./src/observer/README.md)

  - Define one-to-many dependency
  - When an object changes state, all its dependents are notified.

* [Decorator](./src/decorator/README.md)

  - Attaches additional responsibilities to an object dynamically
  - Provides a flexible alternative to subclassing for extending functionality

* [Factory](./src/factory/README.md)

  - Factory Method defines an interface for creating a _single_ object, but let subclasses decide what to instantiate. I.e.: the class defers instatiation to the subclasses.
  - Abstract Factory provides an interface for creating _families_ of objects without specifying their concrete classes.

# Toolbox

- You need [.NET 6](https://www.dot.net) to run these examples.
- Projects created with `dotnet new console --use-program-main -n AppName`
- Used https://github.com/d0pare to compare solutions, get formatting hints, and crib dotnet style.