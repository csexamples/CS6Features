using System;

namespace ConditionalAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            LogMethodName(DoWork);
        }

        public static void LogMethodName(Action action)
        {
            var name = action?.Method?.Name ?? "no name";

            Console.WriteLine(name);
        }

        public static void DoWork()
        {
            Console.WriteLine("Doing work");
        }
    }
}
