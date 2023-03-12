namespace Singletone.Models
{
    public class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;

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

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

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