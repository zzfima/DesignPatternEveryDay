namespace SingletoneThreadSafe.Models
{
    internal sealed class SingletoneEager
    {
        private static int counter = 0;
        private static readonly SingletoneEager instance = new();

        public static SingletoneEager GetInstance
        {
            get => instance;
        }

        private SingletoneEager()
        {
            counter++;
            Console.WriteLine("Counter Value Eager" + counter.ToString());
        }

        public static void PrintDetails(string message)
        {
            Console.WriteLine($"((( {message} )))");
        }
    }
}