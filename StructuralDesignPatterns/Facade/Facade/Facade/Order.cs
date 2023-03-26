using Facade.Models;
using System;

namespace Facade.Facade
{
    public class Order : IOrder
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Place Order Started");

            Product product = new();
            product.GetProductDetails();

            Payment payment = new();
            payment.MakePayment();

            Invoice invoice = new();
            invoice.Sendinvoice();

            Console.WriteLine("Order Placed Successfully");
        }
    }
}