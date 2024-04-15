# Command Pattern

Encapsulates a request as an object to:

- Parameterize clients with different requests.
- Queue or log requests.
- Support undo operations.

## Demo Project

Remote controls for home automation and a variety of vendor "Gadget" classes are implemented.  This allows me to instrument using the gadgets decoupled from the remote itself. Execute and Undo operations are supported on each Command, and complex multi-step Macro Commands are also provided.

## Notes

- Commands decouple the object making a request from the one that knows how to perform it. It sits in between an Invoker and a Receiver. 
- Command objects encapsulate concrete receiver objects and specific commands on that receiver. You will probably have multiple Commands linked to the same Receiver object.
- Invokers make requests via Command objects by calling its methods. This executes the methods on the Receiver or otherwise affects them. This allows the Invoker to change which Commands it uses (and which Receivers it affects) at run-time.
- Depending on need, the Command Interface can have a number of methods that support common use cases:
  - Execute: The most basic command method. Do the thing!
  - Undo: Really common to provide an Undo operation that knows how to go back in time (Shout out to a fav tester-advocate [Noah Sussman]](https://infiniteundo.com/).
  - Store/Load: Allows for recovery, asynchronous command handling, transactional fidelity (all process or none do), and logging of requests.
- Macro Commands can combine several smaller commands together and even support complex Undo operations without much additional logic.
- A Phantom Design Pattern appeared! The Null Object allowed us to fill our Remote up with empty commands upon instantiation. The interface methods are all implemented as stubs with no real content. This prevents us from having to check for null when a button is pressed. 

## Examples and References

- Hotkeys are a good example of the Command Pattern that hit a little closer than the Remote Control object. Swap your Minecraft hotkeys for any other command.  Stop throwing your sword on the ground!
- I found this [practical discussion of Ruby Service Objects and Interactors](https://www.codewithjason.com/code-without-service-objects/) informative in seeing how people _used_ and _abused_ the Command Pattern.
- After this chapter, the [Wikipedia entry](https://en.wikipedia.org/wiki/Command_pattern) was a lot more relatable.