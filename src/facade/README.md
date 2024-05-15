# Facade Pattern

- Provides a unified interface to a set of interfaces in a subsystem.
- Provides a higher-level interface that simplifies interacting with the system as a whole.

## Demo Project

A board game cafe offers presets for those renting time in their game rooms. With the push of one button, you can go from brooding cyberpunk dystopia to epic fantasy and back again.  Of course, you can also do your own thing to make a brooding fantasy dystopia, but that's for the expert users...

## Notes

- Wraps subsystems of many complex interactions that are often done together.
- Does not prevent low-level access.  Merely wraps it.
- Do you need to bundle functionality of existing classes? Perfect!
- Be careful not to violate the Principle of Least Knowledge/Law of Demeter. Only talk to objects you instantiate or receive through the constructor. Don't move through objects to access their components. This prevents tight coupling.
- Adapters, Facades, and Decorators are broadly similar but differ in specific ways:
  - Adapters wrap an object to change its interface.
  - Decorators wrap an object to add new behaviors and responsibilities.
  - Facades wrap a set of objects to simplify interaction with them.
