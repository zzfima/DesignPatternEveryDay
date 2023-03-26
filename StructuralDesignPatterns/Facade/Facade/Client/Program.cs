using Facade.Facade;
using System;

namespace FacadeClient
{
    public class Program
    {
        public static void Main()
        {
            IOrder order = new Order();
            order.PlaceOrder();
            Console.ReadLine();
        }
    }
}