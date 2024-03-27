# Decorator Pattern

* Attaches additional responsibilities to an object dynamically
* Provides a flexible alternative to subclassing

While this is usually used as a building block with other patterns, Decorator objects can add behavior without subclassing.

* Decorators have the same supertype as the objects they decorate.
* You can use one or more decorators to wrap an object.
* We can pass around a wrapped object in the same places the original object was allowed to go.
* Decorator objects add its own behavior before and/or after delegating to the object it decorates to do the rest of the job.
* Objects can be decorated at any time, so behaviors can be added dynamically, at run time, with as many decorators as we like.

## Demo Project

Coffee and add-ons are the focus of this practice project. Coffee drinks form a base set of concrete objects on a Beverage abstration. Add-ons like soy and honey can decorate these beverages at will by implementing the CondimentDecorator abstraction. Both the description and cost change dynamically based on how the objects are used at run-time.

The Sharpen your Pencil activity asked us to add a Size to the base class and use it to calculate a new price for the drink _and_ condiments. If new features are added to the base class, they can be accomodated in decorator objects to enhance functionality as needed.

# Notes

- Decorators allow us to modify behavior without modifying working code. This would be much harder with inheritance.
- Decorators wrap concrete components and are compoatible with those components through inheritance or implementing the same interface.
- Decorators can lead to lots of small classes, and overuse can make things complicated.
