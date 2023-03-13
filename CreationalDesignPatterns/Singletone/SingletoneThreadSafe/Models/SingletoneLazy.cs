namespace SingletoneThreadSafe.Models
{
    internal sealed class SingletoneLazy
    {
        private static int counter = 0;
        private static Lazy<SingletoneLazy> instance = new Lazy<SingletoneLazy>(() => new SingletoneLazy());

        public static SingletoneLazy GetInstance
        {
            get => instance.Value;
        }

        private SingletoneLazy()
        {
            counter++;
            Console.WriteLine("Counter Value Lazy" + counter.ToString());
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine($"[[[ {message} ]]]");
        }
    }
}