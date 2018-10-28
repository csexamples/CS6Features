using System;
using System.Linq;

namespace AddExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = new UserStorage
            {
                new User("sallen"),
                new User("venus"),
                new User("robot")
            };

            Console.WriteLine($"Store count: {store.Count()}");
        }
    }
}
