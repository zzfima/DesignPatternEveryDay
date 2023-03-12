## What is Prototype Design Pattern?
Prototype Design Pattern specifies the kind of objects to create using a prototypical instance, and create new objects by copying this prototype.
Prototype Design Patternw will create a new complete copy of the object. It shallow copy of the the object.


### Points to Remember
1. The MemberwiseClone method is part of the System.Object class and creates a shallow copy of the given object.
2. MemberwiseClone Method only copies the non-static fields of the object to the new object.
3. In the process of copying, if a field is a value type, a bit by bit copy of the field is performed. 
If a field is a reference type, the reference is copied but the referenced object is not.