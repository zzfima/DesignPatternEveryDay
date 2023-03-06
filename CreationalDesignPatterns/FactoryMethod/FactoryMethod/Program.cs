using FactoryMethod.Factory;

namespace FactoryMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var cardFacrory = new TitaniumFactory();
            var card = cardFacrory.CreateProduct();
            Console.WriteLine($"card: {card.GetCardType()}");

            Console.ReadLine();
        }
    }
}