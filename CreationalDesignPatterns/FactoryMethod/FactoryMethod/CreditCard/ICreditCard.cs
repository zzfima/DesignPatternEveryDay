﻿namespace FactoryMethod.CreditCard
{
    internal interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}