using FactoryMethod.CreditCard;

namespace FactoryMethod.Factory
{
    internal class PlatinumFactory : CreditCardFactoryBase
    {
        protected override ICreditCard MakeProduct()
        {
            return new Platinum();
        }
    }
}
