using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Proxy
{
    public class UserRepositoryProxy : IUserRepository
    {
        List<User> _users = new List<User>();
        UserRepository _userRepository;
        public UserRepositoryProxy(UserList userList)
        {
            _userRepository = new UserRepository(userList);
        }
        public bool Add(User user)
        {
            return _userRepository.Add(user);
        }

        public User GetByName(string name)
        {
            User user = _users.FirstOrDefault(x => x.Name == name);
            if (user == null)
            {
                user = _userRepository.GetByName(name);
                _users.Add(user);
            }
            return new User() { Name = user.Name, Password = user.Password };
        }
    }
}
