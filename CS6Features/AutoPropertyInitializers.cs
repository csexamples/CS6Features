using System;

namespace CS6Features
{
    public class User
    {
        public Guid Id { get; } = Guid.NewGuid();

        public string Username { get; protected set; } = String.Empty;
    }
}
