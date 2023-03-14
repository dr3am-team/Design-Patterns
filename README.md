# Design-Patterns

Creational Patterns:


1 -> Factory Method

Factory Method is a pattern that provides a interface for creating objects in a superclass and allows the child classes to modify the type of objects that will be created.
Despite its name, the creator class main responsibility is not creating products, and it usually contains some core business logic that relies on product objects returned by this creator. Subclasses can even change some details of the core logic overriding a method.

When to use this pattern?

-Use the Factory Method when you don’t know beforehand the exact types and dependencies of the objects your code should work with.

-Use the Factory Method when you want to save system resources by reusing existing objects instead of rebuilding them each time.


2 -> Abstract Factory

Abstract Factory is a pattern that lets your produce families or related objects without specifying their concrete class.
The abstract factory interface declares a set of methods that return different abstract products.
Concrete factories produce a family of products that belong to a single variant.
For example: We want to create chairs an tables, but each chair or table can be victorian or modern. So, the abstract factory declares the methdos CreateChair() : Chair and CreateTable(): Table. Now, the concrete factory will create all the products of style modern. So, ModernFactory will be able to return either a modern chair or a modern table, and the type of the return will be an abstract class or interface _Table_ or _Chair_ so the abstract factory will never know wich type of product is being made.

When to use this pattern?

-Use the Abstract Factory when your code needs to work with various families of related products, but you don’t want it to depend on the concrete classes of those products—they might be unknown beforehand or you simply want to allow for future extensibility.

-Consider implementing the Abstract Factory when you have a class with a set of Factory Methods that blur its primary responsibility.


3 -> Builder Pattern

The Builder Pattern allows you to construct complex objects step by step. It allows you to produce different types and representations of an object using the same construction code.
Using the Builder pattern makes sense only when your products are quite complex and require extensive configuration. Such as nested objects, you can build each object in a different step, making the final object in many steps.

When to use this pattern?

-Use the Builder pattern to get rid of a “telescoping constructor”. That means overloading the constructor many times for each variant of the object and some constructors may finish with a lot of parametters, wich is not recommended.


4 -> Prototype Pattern

Prototype is a creational design pattern that lets you copy existing objects without making your code dependent on their classes.
The Prototype pattern delegates the cloning process to the actual objects that are being cloned. If not, we would have to create the object, and iterate through all its fields to copy them, but doing this we would break the privacy of the object and we would being exposing too much the object.
The pattern declares a common interface for all objects that support cloning, usuallt with only one method Clone(). In the concrete object to clone is as simple as implement that method returning a new ObjectName(this).

When to use this pattern?

-Use the Prototype pattern when your code shouldn’t depend on the concrete classes of objects that you need to copy.

-Use the pattern when you want to reduce the number of subclasses that only differ in the way they initialize their respective objects.
 
 
 5 -> Singleton Pattern
 
Singleton is a creational design pattern that ensure that a class has only one instance, allowing acces globally.
Constructor of this class will be private so anyone can instanciate it, and provides a static method to get the instance, where if no one called that method a new instance will be returned, but if that method were called at least once, it will return the existing instance.
 
 When to use this pattern?
 
 - When you want only one instance of a class for all clients, for example, a single database object shared by different parts of the program. 
 
 - Use the Singleton pattern when you need stricter control over global variables.
 
 
 Structural Patterns:
 
 1 -> Adapter
 
Adapter is a structural design pattern that allows objects with incompatible interfaces to collaborate.
If there is a class that you need to use, but its interface is not compatible with the rest of the code, you can use this pattern, that creating a class that support both the interface of the new class and the old class that need the new one, it can make a business logic that includes both classes.
One option is that the adapter class extends the old class so it can operate like that class, and it has an instance of the new class, so you can make logic that includes both classes.
 
 When to use this pattern?
 
 - Use the Adapter class when you want to use some existing class, but its interface isn’t compatible with the rest of your code.
 
 - Use the pattern when you want to reuse several existing subclasses that lack some common functionality that can’t be added to the superclass.
 
 
 2 -> Bridge
 
Bridge is a structural design pattern that lets you split a large class or a set of closely related classes into two separate hierarchies—abstraction and implementation—which can be developed independently of each other.
Without using brinde, a class can get a lot of subclasses for variants of the superclass. For example, a class Shape that has two subclasses, Circle and Square. If we want to add colours to that classes, we should extend Circle and make as much subclasses as colours we want. So, instead, we can make an independent hierarchy, with a superclass Colour, and subclasses with the real implementation, and in the class Shape, we declare an instance of the hierarchy Colour. So, now we can combine any shape with any colour without getting a hierarchy with many subclasses.



3 -> Composite

Composite is a structural design pattern that lets you compose objects into tree structures and then work with these structures as if they were individual objects.
When a project structure is tree-like, I mean, if your hierarchy is structured by products and containers (containers can store products or more containers), and you want to iterate every class for doing something, lets say CalculateTotal(), you could iterate between all objects and asking if its a product or its a containers, and then if its a containers you should iterate that container as well, and that would be messy.
Instead you could apply composite pattern which declares a common interface between all objects in the tree with business logic method, in this case CalculateTotal(), and in the case of composite that method will iterate all the products inside and ask for its total, and in the case of the product it will just return its total. That way, from the client code, you don't need to know if its a final product or a container, you just call the method and the classes work it through.
Imagine a project that contains directorys and files. Directorys can store more directorys or just files (will be stored in a variable of the type of the interface, lets call it Component. So you can just call the method without worrying if its a file or a directory). In the directory class the buisness logic method will iterate the collection of components without knowing its type and calling the method. If the iterator is on a container, will repeat that logic, if its a product it will return the total, so every component will be iterated.

When to use this pattern?

- Use the Composite pattern when you have to implement a tree-like object structure

- Use the pattern when you want the client code to treat both simple and complex elements uniformly.
