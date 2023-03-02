## What is Factory Design Pattern in C#?

Let us first try to understand the definitions of the factory design pattern. 
If you are not understanding the following definitions then don’t worry, we will explain the same with real-time examples. 

According to Gang of Four, the Factory Design Pattern states that 
“A factory is an object which is used for creating other objects”. 
In technical terms, we can say that a factory is a class with a method. 
That method will create and return different types of objects based on the input parameter, 
it received. In simple words, if we have a superclass and n number of subclasses, 
and based on the data provided, if we have to create and return the object of one of the subclasses, 
then we need to use the Factory Design Pattern in C#.

In the Factory Design pattern, we create an object without exposing the object creation logic to 
the client and the client will refer to the newly created object using a common interface. 
The basic principle behind the factory design pattern is that, at run time, 
we get an object of a similar type based on the parameter we pass.

## What is the Problem of the above code implementation?
The above code implementation introduces the following problems

First, the tight coupling between the client class (Program) and Product Class (MoneyBack, Titanium, and Platinum).
Secondly, if we add a new Credit Card, then also we need to modify the Main method by 
adding an extra if-else condition which not only overheads in the development but also in the testing process
