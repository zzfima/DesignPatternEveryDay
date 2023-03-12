using Factory.CreditCards;

internal static class CreditCardFactory
{
    internal static ICreditCard GetCreditCard(string cardType)
    {
        ICreditCard? cardDetails = null;

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

        if (cardDetails == null)
            throw new Exception("Invalid Card Type");


        return cardDetails;
    }
}