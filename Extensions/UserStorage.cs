using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AddExtensions
{
    public class UserStorage : IEnumerable<User>
    {
        public IEnumerator<User> GetEnumerator()
        {

            var allUsers = _defaultUsers.Select(item => item.Value).Concat(_users);

            return allUsers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public User Insert(User newUser)
        {
            _users.Add(newUser);

            return newUser;
        }

        List<User> _users = new List<User>();

        Dictionary<string, User> _defaultUsers = new Dictionary<string, User>()
        {
            ["john"] = new User("John"),
            ["allen"] = new User("Allen")
        };
    }
}
