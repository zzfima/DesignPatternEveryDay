## Example Decorator Design Pattern?

Suppose we want to implement different kinds of cars - we can create interface ICar to define the assemble method and 
then we can have a Basic car, further more we can extend it to Sports car and Luxury Car. 
The implementation hierarchy will look like:

ICar

|

BasicCar

|

SportsCar ; LuxuryCars


if we want to get a car at runtime that has both the features of sports car and luxury car, 
then the implementation gets complex and if further more we want to specify which features should be added first, 
it gets even more complex. Now imagine if we have ten different kind of cars, 
the implementation logic using inheritance and composition will be impossible to manage. 
To solve this kind of programming situation, we apply decorator pattern in java. 
