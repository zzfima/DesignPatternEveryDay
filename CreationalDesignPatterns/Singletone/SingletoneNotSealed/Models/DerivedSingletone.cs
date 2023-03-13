namespace Singletone.Models
{
    public partial class Singleton
    {
        public class DerivedSingletone : Singleton
        {
            public void DerivedPrintDetails(string message)
            {
                base.PrintDetails(message);
                Console.WriteLine("derived " + message);
            }
        }
    }
}