namespace SingletoneThreadSafe.Models
{
    /// <summary>
    /// Thread safe singletone
    /// </summary>
    internal sealed class SingletoneTS
    {
        private static int counter = 0;
        private static SingletoneTS? instance;
        private static readonly object instanceLock = new ();

        //Lazy initialization = on-demand object creation:
        //until and unless we invoke the GetInstance Property of the SingletoneTS class, the SingletoneTS instance is not created.
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

        public static void PrintDetails(string message)
        {
            Console.WriteLine($"### {message} ###");
        }
    }
}