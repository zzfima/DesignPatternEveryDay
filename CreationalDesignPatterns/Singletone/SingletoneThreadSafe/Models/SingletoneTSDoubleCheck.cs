namespace SingletoneThreadSafe.Models
{
    /// <summary>
    /// Thread safe singletone
    /// </summary>
    internal sealed class SingletoneTSDoubleCheck
    {
        private static int counter = 0;
        private static SingletoneTSDoubleCheck? instance;
        private static readonly object instanceLock = new();

        //Lazy initialization = on-demand object creation:
        //until and unless we invoke the GetInstance Property of the SingletoneTSDoubleCheck class, the SingletoneTSDoubleCheck instance is not created.
        //Also, first check if it null. It save us from odd synchronisation
        public static SingletoneTSDoubleCheck GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (instanceLock)
                    {
                        if (instance == null)
                            instance = new SingletoneTSDoubleCheck();
                    }
                }

                return instance;
            }
        }

        private SingletoneTSDoubleCheck()
        {
            counter++;
            Console.WriteLine("Counter Value TS DoubleCheck" + counter.ToString());
        }

        public static void PrintDetails(string message)
        {
            Console.WriteLine($"@@@ {message} @@@");
        }
    }
}