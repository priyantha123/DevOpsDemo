using System;

namespace DevOpsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Singleton singleton = Singleton.GetInstance();
            singleton.LoginId = "Dinesh";
            singleton.RoleId = "Admin";

        }        
    }

    public class Singleton
    {
        private static Singleton instance = null;
        public string LoginId { get; set; }
        public string RoleId { get; set; }
        private Singleton()
        {

        }

        private static object lockThis = new object();

        public static Singleton GetInstance()
        {
            lock(lockThis){
                if (Singleton.instance == null)
                    instance = new Singleton();
            }

            return instance;
        }
    }
}
