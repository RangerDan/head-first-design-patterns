# Template Method Pattern

- Defines the skeleton of an algorithm in the superclass and relies on subclasses to implement the final part of it.
- Allows subclasses to redefine portions of an algorithm without changing the algorithm's structure.

## Demo Project

The board game shop has a problem. They have a ton of used board games that need to be sorted. The most natural way to do that is by the current BoardGameGeek Top 100 score. I've created a List of BoardGames with their scores and implemented the comparator.

## Notes

- Template method defines the steps of an algorithm. Subclasses implement the steps that are not in common with each other.
- Code reuse is the goal. Instead of duplicating the algorithm in every subclass, you only have to specify the important distinctions.
- Template method classes may define concrete methods that can be conditionally overriden, abstract methods that _must_ be implemented, and hooks which can customize how the subclasses use the algorithm.
- As shown in the Array.sort() example, the algorithm may be static and require that objects passed to it adhere to a specific interface. to use the algorithm.
- To ensure the algorithm is not overridden by subclasses, declare it _final_.
- This is a good example of the Hollywood Principle. Subclasses don't call the algorithm, the subclass methods used by the algo are invoked by the superclass algo based on which subclass is present. Other examples include the Factory pattern and its factories determining which type of object to return. Also, the controlling Observer pattern object invokes the Subject methods which in turn reach out for updates.

## Examples and References

As covered in the bookJava uses a ton of this pattern. Array.sort() is a static method that relies on the templated class implementing the Comparable interface. JFrames have the .paint() hook for adding algorithm-bending steps to the display process. And AbstractList is used by ArrayList and LinkedList; implementing new list types requires only a few Template Method definitions.