namespace Singletone.Models
{
    internal sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton? instance;

        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        public static void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}