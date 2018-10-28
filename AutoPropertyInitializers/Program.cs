using System;

namespace AutoPropertyInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            Console.WriteLine($"User id: {user.Id}");
            Console.WriteLine($"Username: {user.Username}");
        }
    }
}
