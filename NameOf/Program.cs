using System;

namespace NameOf
{
    class Program
    {
        static void Main(string[] args)
        {
            DoWork("John");
        }

        public static void DoWork(string name)
        {
            Console.WriteLine($"parameter's {nameof(name)} value is: {name}");
        }
    }
}
