using DIgitalOceanCar.Model;

namespace DIgitalOceanCar.Decorator
{
    internal abstract class CarDecoratorBasic : ICar
    {
        protected readonly ICar _car;

        public CarDecoratorBasic(ICar car)
        {
            _car = car;
        }
        public virtual void Assemble()
        {
            _car.Assemble();
        }
    }
}
