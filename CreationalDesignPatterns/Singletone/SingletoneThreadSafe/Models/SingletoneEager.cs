namespace SingletoneThreadSafe.Models
{
    internal sealed class SingletoneEager
    {
        private static int counter = 0;
        private static SingletoneEager instance = new SingletoneEager();

        public static SingletoneEager GetInstance
        {
            get => instance;
        }

        private SingletoneEager()
        {
            counter++;
            Console.WriteLine("Counter Value Eager" + counter.ToString());
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine($"((( {message} )))");
        }
    }
}