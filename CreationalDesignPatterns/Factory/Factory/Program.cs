using Factory;

//Generally we will get the Card Type from UI.
//Here we are hardcoded the card type
string cardType = "MoneyBack";
ICreditCard cardDetails = null;
//Based of the CreditCard Type we are creating the
//appropriate type instance using if else condition'

cardDetails = CreditCardFactory.GetCreditCard(cardType);

Console.ReadLine();