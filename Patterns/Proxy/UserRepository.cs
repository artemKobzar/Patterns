using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Proxy
{
    public class UserRepository : IUserRepository
    {
        UserList _userList;
        public UserRepository(UserList userList)
        {
            _userList = userList;
        }
        public bool Add(User user)
        {
            if(_userList.Users.FirstOrDefault(x => x.Name == user.Name) != null)
            {
                return false;
            }
            _userList.Users.Add(user);
            return true;
        }

        public User GetByName(string name)
        {
            return _userList.Users.FirstOrDefault(x => x.Name == name) ?? new User { Name = "Empty", Password = "Empty" };
        }
    }
}
