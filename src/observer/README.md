# Observer Pattern

* Define one-to-many dependency
* When an object changes state, all its dependents are notified by the Subject.
* It is "best" if individual Observers control how they retrieve the updated information.

## Demo Project

The Weather Station can then focus on distributing weather info, and the displays can choose what to do with it. What's more, the independent displays can be added, updated, and change how they use the information without interrupting its flow.

## Notes

Observer lets any compatible object be notified when state changes.

- Defines one-to-many relationships
- Subjects update Observers using a common interface
- Observers of any concrete type can participate as long as they implement the Observer interface.
- Observers are loosely-coupled: the Subject only knows that they implement the Observer interface!

## Common uses:

- Spring and other GUI frameworks
- RxJava, JavaBeans, RMI, Cocoa, JavaScript events
- Related to Publish/Subscribe pattern used in queue systems like AWS' SQS and RabbitMQ
- Used again in Model-View-Controller