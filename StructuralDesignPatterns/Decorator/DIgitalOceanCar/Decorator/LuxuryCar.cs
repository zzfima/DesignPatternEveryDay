using DIgitalOceanCar.Model;

namespace DIgitalOceanCar.Decorator
{
    internal class LuxuryCar : CarDecoratorBasic
    {
        public LuxuryCar(ICar car) : base(car) { }

        public override void Assemble()
        {
            base.Assemble();
            Console.WriteLine("Added Luxury features");
        }
    }
}
