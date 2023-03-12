using Prototype;

var emp1 = new Employee { Name = "Vasja", Department = "OMD" };
var emp2 = emp1.GetClone();
emp1.Name = "L1";
emp2.Name = "L2";
Console.WriteLine($"emp1 name: {emp1.Name}, emp2 name: {emp2.Name}");

var emp3 = new Employee { Name = "Vasja", Department = "OMD" };
var emp4 = emp3;
emp3.Name = "L3";
emp4.Name = "L4";
Console.WriteLine($"emp3 name: {emp3.Name}, emp4 name: {emp4.Name}");

Console.ReadLine();
