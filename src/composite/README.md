# Composite Pattern

- Allows you to composite objects into tree-like structures to represent part/whole hierarchies.
- Clients can treat individual and composite components uniformly.

## Demo Project

The Army List uses the Composite Pattern to make a simplified list of figures and units from the tabletop wargame Warhammer 40K. Both individuals and units with more than one figure are trackable using a single collection. And the points add themselves!

## Notes

- Composite Pattern allows for single components (leaf) and collections of components (composite) to be treated the same.
- The goal is to have polymorphic code that can handle a tree collection rather than just a single-dimension collection.
- This pattern has trade-offs, especially when you consider the single-responsibility principle. But you are removing the need to change as the way you store objects, and their relationship to another, gets more complex.