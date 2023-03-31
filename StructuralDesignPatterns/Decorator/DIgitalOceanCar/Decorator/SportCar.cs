using DIgitalOceanCar.Model;

namespace DIgitalOceanCar.Decorator
{
    internal class SportCar : CarDecoratorBasic
    {
        public SportCar(ICar car) : base(car) { }

        public override void Assemble()
        {
            base.Assemble();
            Console.WriteLine("Added Sport features");
        }
    }
}
