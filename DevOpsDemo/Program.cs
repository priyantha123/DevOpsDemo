using System;

namespace DevOpsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }        
    }

    public class Singleton
    {
        private static Singleton instance = null;
        private Singleton()
        {

        }

        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
    }
}
