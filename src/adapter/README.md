# Adapter Pattern

- Converts the interface of one class into the interface for another.
- Allows otherwise incompatible classes to work together.

## Demo Project

Duck and Turkey interfaces are adapted so Duck Clients can use Turkeys and visa versa.

## Notes

- Use an adpater when the existing object's interface is not what you need. Adapt it to match the one you need, so your client can now use the adapted object.
- An Adapter Pattern class usually follows the naming convention of <Target>Adapter. It implements the target interface ITarget, and its constructor accepts the Adaptee class as a parameter.
- Not just a wrapper! A lot of times, you will adapt a class if the interfaces are broadly similar. Most times, you will need to make decisions on what part of the adapted interface you will need. You don't need to implement everything in order to get enough functionality to be useful.
- Object Adapters take one interface and transform it into another. Class Adapters can act as either interface, but they require multiple inheritance.
- Adapters, Facades, and Decorators are broadly similar but differ in specific ways:
  - Adapters wrap an object to change its interface.
  - Decorators wrap an object to add new behaviors and responsibilities.
  - Facades wrap a set of objects to simplify interaction with them.

## Examples and References

[This Stack Overflow thread offers a great list of Java adapters](https://stackoverflow.com/questions/1673841/examples-of-gof-design-patterns-in-javas-core-libraries).