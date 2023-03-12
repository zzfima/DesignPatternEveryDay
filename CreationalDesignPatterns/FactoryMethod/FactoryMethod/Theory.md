## What is Factory Method Design Pattern?
Define an interface for creating an object, but let the subclasses decide which class to instantiate. 
The Factory method lets a class defer instantiation it uses to subclasses.

## When to use the Factory Design Pattern in real-time applications?
It would not be a good programming approach to specify the exact class name while creating the objects by the client,
which leads to tight coupling between the client and the product. 
To overcome this problem, we need to use the Factory Method Design Pattern in C#. 
This design pattern provides the client with a simple mechanism to create the object.

## Diffrence from Factory Design Pattern
Factory is simpler, than Factory Method. But when we add new type, we need change the Factory class, 
becouse we need add 1 more case into switch statement. 
Its violating OCP. 
In case of Factory Method, we do not changes existing classes, but add new one.