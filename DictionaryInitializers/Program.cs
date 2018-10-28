using System;

namespace DictionaryInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            UserStorage userStorage = new UserStorage();

            foreach(var item in userStorage.Users)
            {
                Console.WriteLine($"User key in the user storage: {item.Key}");
                Console.WriteLine($"User name: {item.Value.Name}");
            }
        }
    }
}
