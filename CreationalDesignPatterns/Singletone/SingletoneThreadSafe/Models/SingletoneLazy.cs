namespace SingletoneThreadSafe.Models
{
    internal sealed class SingletoneLazy
    {
        private static int counter = 0;
        private static readonly Lazy<SingletoneLazy> instance = new(() => new SingletoneLazy());

        public static SingletoneLazy GetInstance
        {
            get => instance.Value;
        }

        private SingletoneLazy()
        {
            counter++;
            Console.WriteLine("Counter Value Lazy" + counter.ToString());
        }

        public static void PrintDetails(string message)
        {
            Console.WriteLine($"[[[ {message} ]]]");
        }
    }
}