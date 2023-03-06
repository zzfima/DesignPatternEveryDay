using FactoryMethod.CreditCard;

namespace FactoryMethod.Factory
{
    internal class TitaniumFactory : CreditCardFactoryBase
    {
        protected override ICreditCard MakeProduct()
        {
            return new Titanium();
        }
    }
}
