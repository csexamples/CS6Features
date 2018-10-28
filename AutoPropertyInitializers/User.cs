using System;
namespace AutoPropertyInitializers
{
    public class User
    {
        public Guid Id { get; } = Guid.NewGuid();

        public string Username { get; protected set; } = "Guest";
    }
}
