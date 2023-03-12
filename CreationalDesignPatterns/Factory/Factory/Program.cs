//Generally we will get the Card Type from UI.
//Here we are hardcoded the card type
using Factory.CreditCards;

string cardType = "MoneyBack";

ICreditCard? cardDetails;

//Based of the CreditCard Type we are creating the
//appropriate type instance using if else condition'
cardDetails = CreditCardFactory.GetCreditCard(cardType);

Console.WriteLine($"Card type: {cardDetails.GetCardType()}");

Console.ReadLine();