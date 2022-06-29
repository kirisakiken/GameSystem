# Game System Architecture

A game system submodule that can be used to build generic, extendable game architecture in Unity projects


### Game System
- Holds ownership of all members that exists in the architecture.
- Responsible of collecting, initializing and delivering information on high level architecture members on demand.

#### High Level Members;
- Modules
- Providers
- Tools

---

**Modules** -> Mainly used for driving high level events and operations in architecture.

**Providers** -> Mainly used for providing, preparing requested data.

**Tools** -> Mainly used for UI/User related actions and events.
