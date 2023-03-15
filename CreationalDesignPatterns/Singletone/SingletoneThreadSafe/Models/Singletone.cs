namespace SingletoneThreadSafe.Models
{
    internal sealed class Singletone
    {
        private static int counter = 0;
        private static Singletone? instance;

        public static Singletone GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singletone();
                return instance;
            }
        }

        private Singletone()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        public static void PrintDetails(string message)
        {
            Console.WriteLine($"*** {message} ***");
        }
    }
}