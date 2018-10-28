using System;
using System.Linq;

namespace AddExtensions
{
    public static class UserStorageExtensions
    {
        public static User Add(this UserStorage store, User newUser)
        {
            store.Insert(newUser);

            return newUser;
        }
    }
}
