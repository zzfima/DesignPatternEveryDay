using Factory;


internal static class CreditCardFactory
{
    internal static ICreditCard GetCreditCard(string cardType)
    {
        ICreditCard cardDetails = null;

        if (cardType == "MoneyBack")
        {
            cardDetails = new MoneyBack();
        }
        else if (cardType == "Titanium")
        {
            cardDetails = new Titanium();
        }
        else if (cardType == "Platinum")
        {
            cardDetails = new Platinum();
        }
        if (cardDetails != null)
        {
            Console.WriteLine("CardType : " + cardDetails.GetCardType());
            Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
            Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
        }
        else
        {
            throw new Exception("Invalid Card Type");
        }

        return cardDetails;
    }
}