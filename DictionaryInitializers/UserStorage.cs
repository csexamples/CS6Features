using System;
using System.Collections.Generic;

namespace DictionaryInitializers
{
    public class UserStorage
    {
        public Dictionary<string, User> Users = new Dictionary<string, User>
        {
            ["john"] = new User("John"),
            ["allen"] = new User("Allen")
        };
    }
}
