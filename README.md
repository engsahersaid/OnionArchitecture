# Onion Architecture

The Onion Architecture is a software design pattern that separates the application into layers, each with its own responsibility and dependency. The layers are arranged in a concentric onion-like structure, with the outermost layer representing the application's interface with the outside world.
The Onion Architecture term was coined by Jeffrey Palermo in 2008.
the main goal of Onion Architecture is to provide a better way for building applications with some key factors  testability, maintainability, and dependability on external infrastructures like databases. and it fixes the common problems of N-Tier architecture Coupling and separation of concerns

## Software Architecture Design Principles

### Tight Coupling

When a class is dependent on a concrete dependency, it is said to be tightly coupled to that class. A tightly coupled object is dependent on another object; that means changing one object in a tightly coupled application, often requires changes to a number of other objects. It is not difficult when an application is small but in an enterprise-level application, it is too difficult to make the changes.

### Loose Coupling

It means two objects are independent and an object can use another object without being dependent on it. It is a design goal that seeks to reduce the interdependencies among components of a system to reduce the risk that changes in one component will require changes in any other component.

### Dependency Inversion Principle DIP

High-level modules should not depend on low-level modules both should depend on abstractions.
Abstractions should not depend on details. Details should depend on Abstractions.
`You can learn more about DIP in SOLID`

## Advantages Of Onion Architecture

- Loose Coupling n as the outer layer of the application always communicates with the inner layer via interfaces. not depend on objects
- Testability
- Maintainability
- Dependability on external infrastructures like databases.
- Separation of Concerns
- The internal layers never depend on the external layer. The code that may have changed should be part of an external layer.
- Using dependency inversion depending on abstractions (interfaces) and not the implementations, allows us to switch out the implementation at runtime
- Write business logic without concern about any of the implementation details.
- Database Independent

## Layers

- Domain
- Service
- Infrastructure
- Presentation
We consider that the infrastructure and presentation layers are at the same level.
you can add more layers like for Testing

### Flow of Dependencies

as it is like an onion The flow of dependencies direction from the outer to inner layers
The outer layers are all allowed to reference the layers that are directly below them in the hierarchy.
The Domain layer does not have any direct dependencies on the outside layers.
We can use lower layers of the Onion architecture to define contracts or interfaces. The outer layers of the architecture implement these interfaces.  This means that in the Domain layer, we do not concern ourselves with infrastructure details such as the database or external services.

Using this approach, we can encapsulate all of the rich business logic in the Domain and Service layers without ever having to know any implementation details.

### Domain Layer

The Domain layer is at the core of the Onion architecture. It contains the business logic of the application.
Encapsulate application business logic and rules
do not depend on external infrastructure concerns

- Models / Entities
- Repository interfaces
- Exceptions
- Domain services

### Service Layer

The Service layer is the next layer in the Onion architecture. It is responsible for encapsulating the business logic of the application. It is the layer that contains the application's use cases.

- Domain services implementations
- Domain interfaces
- Contracts
- ViewModel or  Dto
- Validation rules

you can split the Service layer into 2 projects:

- Service project
- Services.Abstraction

### Infrastructure Layer

we are concerned with related to external systems or services that our application is interacting with.

- Database
- External services
- File system
- Identity Provider
- Logging
- Email Service

you can split infrastructure into multiple projects every project has a single responsibility with a single external system instead of one project for all external systems

### Presentation Layer

The Presentation Layer is to represent the entry point to our system so that consumers can interact with the data.
You can implement this layer in many ways, for example creating a REST API, gRPC, desktop application,  etc.

## Technologies Used

- .Net Core 8
- Onion Architecture
- Entity Framework Core
- Swagger

## References

- [Onion Architecture](https://jeffreypalermo.com/2008/07/the-onion-architecture-part-1/)
- [Onion Architecture in ASP.NET Core](https://code-maze.com/onion-architecture-in-aspnetcore/)
- [Github](https://github.com/CodeMazeBlog/onion-architecture-aspnetcore/tree/main)
