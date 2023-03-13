namespace SingletoneThreadSafe.Models
{
    /// <summary>
    /// Thread safe singletone
    /// </summary>
    internal sealed class SingletoneTS
    {
        private static int counter = 0;
        private static SingletoneTS instance = null;
        private static object instanceLock = new object();

        public static SingletoneTS GetInstance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                        instance = new SingletoneTS();
                }

                return instance;
            }
        }

        private SingletoneTS()
        {
            counter++;
            Console.WriteLine("Counter Value TS " + counter.ToString());
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine($"### {message} ###");
        }
    }
}