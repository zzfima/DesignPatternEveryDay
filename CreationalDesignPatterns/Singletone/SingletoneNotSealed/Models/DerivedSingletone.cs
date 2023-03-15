namespace Singletone.Models
{
    public partial class Singleton
    {
        public class DerivedSingletone : Singleton
        {
            public void DerivedPrintDetails(string message)
            {
                PrintDetails(message);
                Console.WriteLine("derived " + message);
            }
        }
    }
}