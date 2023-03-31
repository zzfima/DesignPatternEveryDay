using DIgitalOceanCar.Decorator;
using DIgitalOceanCar.Model;

var car = new BasicCar();
var luxuryCar = new LuxuryCar(car);
var sportLuxuryCar = new SportCar(luxuryCar);

sportLuxuryCar.Assemble();


Console.ReadLine();