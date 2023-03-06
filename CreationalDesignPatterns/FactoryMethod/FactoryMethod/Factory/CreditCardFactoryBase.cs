using FactoryMethod.CreditCard;

namespace FactoryMethod.Factory
{
    internal abstract class CreditCardFactoryBase
    {
        protected abstract ICreditCard MakeProduct();

        public ICreditCard CreateProduct()
        {
            return MakeProduct();
        }
    }
}
