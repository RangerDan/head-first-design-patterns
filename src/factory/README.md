# Factory Pattern

* Defines an interface for creating an object or objects.
* Defer instantiation to subclasses

This is a hallmark of one of the OO Principles of Dependency Inversion: depend on abstractions.  Do not depend on concrete objects. You never know when you will need to make more or replace the concrete classes.

## Demo Projects

* SimplePizzeria is an example of the Simple Factory pseudo-pattern.
* Pizzeria is an example of the Factory Method pattern.
* AbstractPizzeria is an example of the Abstract Factory pattern.

The Simple Factory creates an object to do the instantiation of concrete classes. You decide which dependent class to instantiate based on logic. It is not truly decoupled, but it can be helpful.

For the Factory Method pattern, an abstract class of stores depends on an abstract class of Pizzas. The abstractions avoid dependency on concrete classes so the implementations can vary independently while the interface remains unchanged.

So too with the Abstract Factory pattern, the abstractions only depend on each other. The concrete classes implement an interface and they are decoupled from the other concrete classes. The ingredients for a pizza have been encapsulated so they are decided by the factory they come from and not the store itself. All pizzas can use CreateCheese, but NYPizzas get Reggiano while Chicago pizzas get Mozzarella.

## Notes

- Factories encapsulate object creation.
- Decouples clients (those that use your classes) from concrete objects and implementations. Like Slurm, you don't need to know how it is made to make use of it.
- Factory Method relies on inheritance: subclasses implement factory methods to create objects.
- Abstract Factory Method relies on composition. The interface has factory methods that are specified in implementations.
- Promotes loose coupling by reducing the dependency on concrete classes.
- I recognize Factory patterns in a lot of the Dependency Injection used by frameworks. Both are cases of Dependency Inversion.

## Examples and Tutorials

- https://refactoring.guru/design-patterns/factory-method
- Shiv Kumar, Factory Pattern Method C#, https://www.youtube.com/watch?v=7q3T0gGISyk
