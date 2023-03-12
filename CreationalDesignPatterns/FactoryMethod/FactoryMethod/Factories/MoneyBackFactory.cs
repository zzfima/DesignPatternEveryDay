using FactoryMethod.CreditCard;

namespace FactoryMethod.Factory
{
    internal class MoneyBackFactory : CreditCardFactoryBase
    {
        protected override ICreditCard MakeProduct()
        {
            return new MoneyBack();
        }
    }
}
